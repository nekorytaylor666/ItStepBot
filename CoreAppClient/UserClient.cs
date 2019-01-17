using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppCoreModels;

namespace CoreAppClient
{
    public partial class ApiClient
    {
        public async Task<List<UserModel>> GetUsers()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "users/"));
            return await GetAsync<List<UserModel>>(requestUrl);
        }

        public async Task<List<UserModel>> GetGroup(string group)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "users/"),$"?group={group.ToUpper()}");
            return await GetAsync<List<UserModel>>(requestUrl);
        }

        public async Task<Message<UserModel>> SaveUser(UserModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "users/"));
            return await PostAsync(requestUrl, model);
        }
    }
}
