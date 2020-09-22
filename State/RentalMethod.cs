using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class RentalMethod
    {
        private const int FULLY_RENTED = 0;
        private const int WAITING = 1;
        private const int GOT_APPLICATION = 2;
        private const int APARTMENT_RENTED = 3;
        private Random random;
        private int numberApartments;
        private int state = WAITING;
        public RentalMethod(int n)
        {
            numberApartments = n;
            random = new Random(DateTime.Now.Millisecond);
        }
        public void getApplication()
        {
            switch (state)
            {
                case FULLY_RENTED:
                    {
                        Console.WriteLine("Sorry,we're fully rented.");
                        break;
                    }
                case WAITING:
                    {
                        state = GOT_APPLICATION;
                        Console.WriteLine("Thanks for the application.");
                        break;
                    }
                case GOT_APPLICATION:
                        {
                            Console.WriteLine("We already got your application.");
                            break;
                        }
                case APARTMENT_RENTED:
                        {
                            Console.WriteLine("Hang on,we're renting you an apartment.");
                            break;
                        }
            }
        }
        public void checkApplication()
        {
            int yesno = random.Next() % 10;
            switch (state)
            {
                case FULLY_RENTED:
                    {
                        Console.WriteLine("Sorry,we're fully rented.");
                        break;
                    }
                case WAITING:
                    {
                        Console.WriteLine("You have to submit an application.");
                        break;
                    }
                case GOT_APPLICATION:
                    {
                        if (yesno > 4 && numberApartments > 0)
                        {
                            Console.WriteLine("Congratulation,you were approved.");
                            state = APARTMENT_RENTED;
                            rentApartment();
                        }
                        else
                        {
                            Console.WriteLine("Sorry,you were not approved.");
                            state = WAITING;
                        }
                        break;
                    }
                case APARTMENT_RENTED:
                    {
                        Console.WriteLine("Hang on,we're renting you an apartment.");
                        break;
                    }
            }
        }

        private void rentApartment()
        {
            switch (state)
            {
                case FULLY_RENTED:
                    {
                        Console.WriteLine("Sorry,we're fully rented.");
                        break;
                    }
                case WAITING:
                    {
                        Console.WriteLine("You have to submit an application.");
                        break;
                    }
                case GOT_APPLICATION:
                    {
                        Console.WriteLine("You must have your application checked.");
                        break;
                    }
                case APARTMENT_RENTED:
                    {
                        Console.WriteLine("Renting you an apartment...");
                        numberApartments--;
                        dispenseKeys();
                        break;
                    }
            }
        }

        private void dispenseKeys()
        {
            switch (state)
            {
                case FULLY_RENTED:
                    {
                        Console.WriteLine("Sorry, we’re fully rented.");
                        break;
                    }
                case WAITING:
                    {
                        Console.WriteLine("You have to submit an application.");
                        break;
                    }
                case GOT_APPLICATION:
                    {
                        Console.WriteLine("You must have your application checked.");
                        break;
                    }
                case APARTMENT_RENTED:
                    {
                        Console.WriteLine("Here are your keys!");
                        state = WAITING;
                        break;
                    }
            }
        }
    }
}
