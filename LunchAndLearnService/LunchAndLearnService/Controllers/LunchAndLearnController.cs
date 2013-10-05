using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AttributeRouting.Web.Http;
using LunchAndLearnService.Data;
using LunchAndLearnService.Models;

namespace LunchAndLearnService.Controllers
{
    public class LunchAndLearnController : ApiController
    {
        private static readonly LunchAndLearnRepository _repository;

        static LunchAndLearnController()
        {
            _repository = new LunchAndLearnRepository();
        }

        #region User Methods

        [GET("Users")]
        public IEnumerable<User> GetAllUsers()
        {
            return _repository.Users;
        }

        [GET("Users/{id}")]
        public User GetUserById(int id)
        {
            return _repository.Users.Single(u => u.UserId == id);
        }

        #endregion

        #region Groups Methods

        [GET("Groups")]
        public IEnumerable<Group> GetAllGroups()
        {
            return _repository.Groups;
        }

        [GET("Groups/{id}")]
        public Group GetGroupById(int id)
        {
            var groupById = _repository.Groups.Single(g => g.GroupId == id);
            return groupById;
        }

        [GET("Groups/{id}/Users")]
        public IEnumerable<User> GetUsersForGroupById(int id)
        {
            var grp = _repository.Groups.Single(g => g.GroupId == id);
            if (grp != null)
            {
                return from userId in grp.MemberIds
                       join user in _repository.Users
                       on userId equals user.UserId
                       select user;
            }
            return null;
        }

        #endregion
    }
}