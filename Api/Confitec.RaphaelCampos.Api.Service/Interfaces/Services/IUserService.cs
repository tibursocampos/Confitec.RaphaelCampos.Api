using Confitec.RaphaelCampos.Api.Domain.Entities;
using Confitec.RaphaelCampos.Api.Service.DTO;
using Confitec.RaphaelCampos.Api.Service.Interfaces.Services.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Confitec.RaphaelCampos.Api.Service.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        /// <summary>
        /// Searches all registered users.
        /// </summary>
        /// <returns>Returns a list of all users</returns>
        Task<IEnumerable<UserDto>> GetAllUsersAsync();

        /// <summary>
        /// Searches for the user by ID.
        /// </summary>
        /// <param name="userId">The ID that represents the user to be searched.</param>
        /// <returns>Returns the user corresponding to the entered ID.</returns>
        Task<UserDto> GetUserByIdAsync(int userId);

        /// <summary>
        /// Searches for the user by E-mail.
        /// </summary>
        /// <param name="email">The E-mail that represents the user to be searched.</param>
        /// <returns>Returns the user corresponding to the entered ID.</returns>
        Task<UserDto> GetUserByEmailAsync(string email);

        /// <summary>
        /// Adds a new user record.
        /// </summary>
        /// <param name="userDto">The user entity that will be added.</param>
        /// <returns>Returns the user that was created and its information.</returns>
        Task<UserDto> AddUserAsync(UserDto userDto);

        /// <summary>
        /// Updates a user's record.
        /// </summary>
        /// <param name="userDto">The user entity that will be updated.</param>
        /// <returns>Returns the user that was updated and its information.</returns>
        Task<UserDto> UpdateUserAsync(UserDto userDto);

        /// <summary>
        /// Removes a user according to his ID.
        /// </summary>
        /// <param name="userId">The ID that represents the user to be removed.</param>
        /// <returns>A boolean indicating the status of the operation.</returns>
        Task<bool> RemoveUserByIdAsync(int userId);

        /// <summary>
        /// Removes user from his object.
        /// </summary>
        /// <param name="userDto">The user entity that will be removed.</param>
        /// <returns>A boolean indicating the status of the operation.</returns>
        Task<bool> RemoveUserAsync(UserDto userDto);
    }
}
