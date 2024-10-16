namespace Badget01.DataAccess
{
    public class GetUserRights
    {
        public async Task<bool> CheckPcRights(string pcDomainName) 
        {
            // do some staff
            // execution time approximately 5000 miliseconds
            await Task.Delay(5000); // emulate execution delay
            return true;
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
