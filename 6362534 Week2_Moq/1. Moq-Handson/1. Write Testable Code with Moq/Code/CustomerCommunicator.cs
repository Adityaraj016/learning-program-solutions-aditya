namespace CustomerCommLib
{
    public class CustomerCommunicator
    {
        private readonly IMailSender _mailSender;

        public CustomerCommunicator(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            string toAddress = "cust123@abc.com";
            string message = "Some Message";

            _mailSender.SendMail(toAddress, message);

            return true;
        }
    }
}
