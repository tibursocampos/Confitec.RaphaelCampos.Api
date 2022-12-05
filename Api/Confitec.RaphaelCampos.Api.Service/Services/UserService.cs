using Confitec.RaphaelCampos.Api.Domain.Entities;
using Confitec.RaphaelCampos.Api.Domain.Shared;
using Confitec.RaphaelCampos.Api.Domain.Utils;
using Confitec.RaphaelCampos.Api.Persistence.Interfaces.Repositories;
using Confitec.RaphaelCampos.Api.Service.DTO;
using Confitec.RaphaelCampos.Api.Service.Interfaces.Services;
using Confitec.RaphaelCampos.Api.Service.Services.Shared;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Confitec.RaphaelCampos.Api.Service.Services
{
    public class UserService : ServiceBase<User>, IUserService, IUserRepository
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;

        public UserService(IUserRepository userRepository, ILogger logger) : base(userRepository)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            try
            {
                var users = await _userRepository.GetAllAsync();
                List<UserDto> usersDto = new();
                foreach (var user in users)
                {
                    usersDto.Add(new UserDto(user));
                }

                return usersDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw;
            }
        }

        public async Task<UserDto> GetUserByIdAsync(int userId)
        {
            try
            {
                var user = await _userRepository.GetByIdAsync(userId);
                if (user is null)
                {
                    return default;
                }

                return new UserDto(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw;
            }
        }

        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            try
            {
                if (!email.IsValidEmailFormat())
                {
                    throw new FormatException($"{Constants.INVALID_EMAIL} | {email}");
                }
                var users = await _userRepository.GetAllAsync();
                var user = users.FirstOrDefault(user => user.UserEmail.Equals(email));

                return user is not null ? new UserDto(user) : default;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw;
            }
        }

        public async Task<UserDto> AddUserAsync(UserDto userDto)
        {
            try
            {
                if (await GetUserByEmailAsync(userDto.UserEmail) is not null)
                {
                    throw new ArgumentException(Constants.USER_ALREADY_REGISTERED, JsonConvert.SerializeObject(userDto));
                }

                User user = new(userDto.FirstName, userDto.LastName, userDto.UserEmail, userDto.UserBirthdayDate, userDto.Schooling);
                var createdUser = await _userRepository.AddAsync(user);

                return new UserDto(createdUser as User);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw;
            }
        }

        public async Task<UserDto> UpdateUserAsync(UserDto userDto)
        {
            try
            {
                User user = await _userRepository.GetByIdAsync(userDto.Id);
                if(user is null)
                {
                    return default;
                }

                user.Update(userDto.Id, userDto.FirstName, userDto.LastName, userDto.UserEmail, userDto.UserBirthdayDate, userDto.Schooling);
                await _userRepository.UpdateAsync(user);

                return userDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw;
            }
        }

        public async Task<bool> RemoveUserByIdAsync(int userId)
        {
            var exist = await UserExistsAsync(userId);
            if (!exist)
            {
                return default;
            }

            await _userRepository.DeleteByIdAsync(userId);
            return true;
        }

        public async Task<bool> RemoveUserAsync(UserDto userDto)
        {
            var exist = await UserExistsAsync(userDto.Id);
            if (!exist)
            {
                return default;
            }

            User user = await _userRepository.GetByIdAsync(userDto.Id);
            await _userRepository.DeleteAsync(user);
            return true;
        }

        private async Task<bool> UserExistsAsync(int userId)
        {
            var users = await _userRepository.GetAllAsync();
            return users.Any(p => p.Id == userId);
        }
    }
}