using MailKit.Net.Smtp;
using MimeKit;

namespace BankConsole;

public static class EmailService    {
    public static void SendMail()   {

    }

    private static string GetEmailText()    {
        List<User> newUsers = Storage.GetNewUsers();

        if(newUsers.Count == 0)
            return "No nuevos usuarios";
        
        string emailText = "Usuarios agregados hoy: \n";

        foreach (User user in newUsers)
            emailText += "\t+ " + user.ShowData() + "\n";
        
        return emailText;
    }
}