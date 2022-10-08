using System;

namespace _2020510062_özgürdoruk_Rüşvenli
{
    class Program
    {
        static void Main(string[] args)
        {
            bool player_turn = true;

            int point1 = 120, point2 = 120, b = 0, arr1 = 0, arr2 = 0, arr3 = 0;

            string[] names = new string[12] { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
            int[] scores = new int[12] { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };

            string[] sayilar = new string[15];
            Random rnd = new Random();
            string[] sayilar1 = new string[15];
            string[] sayilar2 = new string[15];

            bool shoot_decision = true;
            while (shoot_decision)
            {
                int shoot;
                Random a = new Random();
                shoot = a.Next(1, 4);//I created a random shot from which array I will write

                if (arr1 == 15 && shoot == 1)//I used another random to print to the others when the first array is full
                {
                    shoot = a.Next(2, 4);
                }

                if (shoot == 1)//A1 array
                {
                    b = rnd.Next(1, 4);//This random for letters

                    if (b == 1)
                    {
                        sayilar[arr1] = "D";
                    }
                    else if (b == 2)
                    {
                        sayilar[arr1] = "E";
                    }
                    else if (b == 3)
                    {
                        sayilar[arr1] = "U";
                    }
                    arr1++;

                }
                if (arr2 == 15 && shoot == 2)
                {
                    shoot = 3;
                }

                else if (shoot == 2)//a2
                {
                    b = rnd.Next(1, 4);//This random for letters

                    if (b == 1)
                    {
                        sayilar1[arr2] = "D";
                    }
                    else if (b == 2)
                    {
                        sayilar1[arr2] = "E";
                    }
                    else if (b == 3)
                    {
                        sayilar1[arr2] = "U";
                    }
                    arr2++;
                }


                if (arr3 == 15 && shoot == 3)
                {
                    shoot = a.Next(1, 3);
                }

                else if (shoot == 3)//A3
                {
                    b = rnd.Next(1, 4);//This random for letters

                    if (b == 1)
                    {
                        sayilar2[arr3] = "D";
                    }
                    else if (b == 2)
                    {
                        sayilar2[arr3] = "E";
                    }
                    else if (b == 3)
                    {
                        sayilar2[arr3] = "U";
                    }
                    arr3++;
                }
                for (int o = 0; o < 13; o++)// STRAIGHT DEU CONTROL
                {
                    if ((sayilar[o] == "D") && (sayilar[o + 1] == "E") && (sayilar[o + 2] == "U"))
                    {
                        shoot_decision = false;

                    }
                    if ((sayilar1[o] == "D") && (sayilar1[o + 1] == "E") && (sayilar1[o + 2] == "U"))
                    {
                        shoot_decision = false;

                    }
                    if ((sayilar2[o] == "D") && (sayilar2[o + 1] == "E") && (sayilar2[o + 2] == "U"))
                    {
                        shoot_decision = false;

                    }
                }

                for (int o = 0; o < 13; o++)//REVERSE DEU CONTROL 
                {
                    if ((sayilar[o] == "U") && (sayilar[o + 1] == "E") && (sayilar[o + 2] == "D"))
                    {
                        shoot_decision = false;

                    }
                    if ((sayilar1[o] == "U") && (sayilar1[o + 1] == "E") && (sayilar1[o + 2] == "D"))
                    {
                        shoot_decision = false;

                    }
                    if ((sayilar2[o] == "U") && (sayilar2[o + 1] == "E") && (sayilar2[o + 2] == "D"))
                    {
                        shoot_decision = false;

                    }
                }

                for (int o = 0; o < 15; o++)//VERTİCALLY  DEU CONTROL
                {
                    if ((sayilar[o] == "D") && (sayilar1[o] == "E") && (sayilar2[o] == "U"))
                    {
                        shoot_decision = false;

                    }
                }
                for (int o = 0; o < 15; o++)//VERTİCALLY  DEU CONTROL
                {
                    if ((sayilar[o] == "U") && (sayilar1[o] == "E") && (sayilar2[o] == "D"))
                    {
                        shoot_decision = false;

                    }
                }
                for (int o = 0; o < 13; o++)//DİAGONAL 1 DEU CONTROL
                {
                    if ((sayilar[o] == "D") && (sayilar1[o + 1] == "E") && (sayilar2[o + 2] == "U"))
                    {
                        shoot_decision = false;

                    }
                }
                for (int o = 0; o < 13; o++)//DİAGONAL 2 DEU CONTROL
                {
                    if ((sayilar[o] == "U") && (sayilar[o + 1] == "E") && (sayilar[o + 2] == "D"))
                    {
                        shoot_decision = false;

                    }
                }
                for (int o = 0; o < 13; o++)//DİAGONAL 3 DEU CONTROL
                {
                    if ((sayilar[o + 2] == "D") && (sayilar[o + 1] == "E") && (sayilar[o] == "U"))
                    {
                        shoot_decision = false;

                    }
                }
                for (int o = 0; o < 13; o++)//DİAGONAL 4 DEU CONTROL
                {
                    if ((sayilar[o + 2] == "U") && (sayilar[o + 1] == "E") && (sayilar[o] == "D"))
                    {
                        shoot_decision = false;

                    }
                }
                if (player_turn == true)
                {
                    point1 -= 5;
                    Console.WriteLine("Player1:   " + "(P1-" + point1 + " P2-" + point2 + ")");

                }
                if (player_turn == false)
                {
                    point2 -= 5;
                    Console.WriteLine("Player2:   " + "(P1-" + point1 + " P2-" + point2 + ")");

                }

                Console.Write("A1 ");
                for (int y = 0; y < arr1; y++)//where the first array is written
                {
                    Console.Write(sayilar[y]);
                }
                Console.WriteLine();
                Console.Write("A2 ");
                for (int y = 0; y < arr2; y++)//where the second array is written
                {
                    Console.Write(sayilar1[y]);
                }
                Console.WriteLine();
                Console.Write("A3 ");
                for (int y = 0; y < arr3; y++) //where the third array is written
                {
                    Console.Write(sayilar2[y]);
                }

                if (point1 == 0 && point2 == 0)//equality status
                {
                    shoot_decision = false;

                }

                player_turn = !player_turn; //change the order of the game player1 to player2         

                Console.ReadLine();
                Console.Clear();
            }

            int winner = 0;
            string winner_name = " ";
            if (point2 > point1)//If the game ends when player2's score is high, player1 wins because it starts 5 points less.
            {
                winner = point1;
                winner_name = "Player1";
            }
            else if (point1 == 0 && point2 == 0)//equality status
            {

                Console.WriteLine("Game is Tie");
            }
            else //else situation player2 wins
            {
                winner = point2;
                winner_name = "Player2";
            }
            int counter = 0;
            for (int i = 0; i < scores.Length; i++)//we find where our score is in the score array
            {
                if (scores[i] > winner)
                {
                    counter++;// this determines our place
                }
                else
                {
                    break;
                }

            }
            string[] new_names = new string[13];//we create 2 new arrays for name and score
            int[] new_scores = new int[13];
            for (int i = 0; i < counter; i++)
            {
                new_names[i] = names[i];
                new_scores[i] = scores[i];

            }
            new_names[counter] = winner_name;//our score is placed inside the array
            new_scores[counter] = winner;
            for (int i = counter + 1; i < new_names.Length; i++)//and the rest of the array is written
            {
                new_names[i] = names[i - 1];
                new_scores[i] = scores[i - 1];

            }
            for (int i = 0; i < new_names.Length; i++)
            {
                Console.WriteLine(new_names[i] + "\t" + new_scores[i]);//Score Table
            }
        }
    }
}
