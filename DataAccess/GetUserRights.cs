namespace Badget01.DataAccess
{
    public class GetUserRights
    {
        public async Task<bool> CheckDomainMetinvest(string domainName) 
        {
            // do some staff
            // execution time approximately 2000 miliseconds
            await Task.Delay(2000); // emulate execution delay
            return true;
        }

        public async Task<bool> CheckLdapAccess(string ldapURL)
        {
            // do some staff
            // execution time approximately 3000 miliseconds
            await Task.Delay(3000); // emulate execution delay
            return true;
        }

        public async Task<bool> CheckPcRights(string pcDomainName) 
        {
            // do some staff
            // execution time approximately 5000 miliseconds
            await Task.Delay(5000); // emulate execution delay
            return false;
        }

        public async Task<bool> CheckUserRights(string userDomainName)
        {
            // do some staff
            // execution time approximately  5000 miliseconds
            await Task.Delay(5000); // emulate execution delay
            return true;
        }
    }
}
