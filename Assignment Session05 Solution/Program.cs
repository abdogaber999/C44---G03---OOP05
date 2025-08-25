using Assignment_Session05_Solution.NotificationService;

namespace Assignment_Session05_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1- Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.

            Circle circle = new Circle(5);
            circle.DisplayShapeInfo();

            Rectangle rectangle = new Rectangle(4, 6);
            rectangle.DisplayShapeInfo();

            Console.ReadLine();




            #endregion

            #region Q2- We start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser. The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.

            IAuthenticationService authService = new BasicAuthenticationService();

            if (authService.AuthenticateUser("admin", "1234"))
            {
                Console.WriteLine("User authenticated successfully!");

                if (authService.AuthorizeUser("admin", "Admin"))
                {
                    Console.WriteLine("User authorized as Admin.");
                }
                else
                {
                    Console.WriteLine("User is not authorized for this role.");
                }
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }

            #endregion

            #region Q3- we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.

            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("abdo@gmail.com", "Welcome via Email!");
            smsService.SendNotification("01000000001", "Welcome via SMS!");
            pushService.SendNotification("User999", "Welcome via Push Notification!");


            #endregion



        }
    }
}
