using Modul9_TugasAPI.Models.Dto;

namespace Modul9_TugasAPI.Data
{
    public static class AccountStore
    {
        public static List<AccountDTO> accountList = new List<AccountDTO>
        {
             new AccountDTO{Id=1, Username="daffa", Password="rinrin"},
             new AccountDTO{Id=2, Username="fadel", Password="levylevy"}
        };
    }
}
