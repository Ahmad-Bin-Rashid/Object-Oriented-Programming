using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using EZInput;

namespace game
{
    internal class Program
    {
        const int scrColumns = 25;
        const int scrRows = 167;

        static string[,] maze1 = new string[,]
        {
                {"#######################################################################################################################################################################"},
                {"                                                                ############                #######            #########                     #############             "},
                {"                                                                      ##########       ##########          ########                           ############             "},
                {"                                                                           #################            ########                             ###########               "},
                {"                                                                             ####     #######################                                 ##########               "},
                {"                                                                             ######         ############                                      #########                "},
                {"                                                                             ######                                                            ##########              "},
                {"                                                                              ###                                                               #########              "},
                {"                                                                               ##                                                                ##   ##               "},
                {"                                                                                #                                                                      #               "},
                {"                                                                                                                                                                       "},
                {"                                                                                                                                                                       "},
                {"                                                                                                                                                                       "},
                {"                                                                                                                                                                       "},
                {"                                                                                                                                                                       "},
                {"                                                                                                                                                                       "},
                {"                                                Q  Q  Q                                                                                                                "},
                {"                                                              Q                                                                                                        "},
                {"                                              ############                                                                                                             "},
                {"                                                                                                                                                                       "},
                {"                                       #######                                                                                                                         "},
                {"                                       #######                                                    E                                                                    "},
                {"                                #####    ###                                                                                                                           "},
                {"                                 ###     ###                                                                   ######                                                  "},
                {"#######################################################################################################################################################################" },
            };
        
        static string[,] maze2 = new string[,]
            {
                {"######################################################################################################################################################################"},
                {"             #############              ##############                                                     T        ################                                  "},
                {"         ########    #######    #############                                                                        #############                                    "},
                {"        ##                ########                                                                                   ##########                                       "},
                {"                                                                             Q  Q                                   ##############                                    "},
                {"                                                                                                                    ###      ####                                     "},
                {"                                                                    Q    ############                                                                                 "},
                {"                                                                                                                                                                      "},
                {"                    Q Q Q                                     Q   #######                                                                                             "},
                {"                    Q Q Q                                                                                                                                             "},
                {"                    Q Q Q                               Q   ######                  #########                                                                         "},
                {"                   #######                                                                                                                                            "},
                {"                                                Q    #######                                                                                                          "},
                {"                        ########                                                                                                                                      "},
                {"                              #######         #######                                       ########                                                                  "},
                {"                                                                                                                                                                      "},
                {"                                         ######                                                                                                                       "},
                {"                                                                                                                                                                      "},
                {"                               Q   #######                                          ########                                                                          "},
                {"                       Q                                                   #########                                                                                  "},
                {"                             #######                                                                                               Q   Q                              "},
                {"                   #############                                                                                                                                      "},
                {"                    ###     ###                                     #######                                                       ########                            "},
                {"           #######  ###     ###                                                                                                                                       "},
                {"######################################################################################################################################################################" },
            };

        static string[,] maze3 = new string[,]
            {
                {"######################################################################################################################################################################"},
                {"                        ######################            #########                                            #############################                          "},
                {"                                 ####################   #####                                        #####################             ########                       "},
                {"                                          ###############                                                           #############################                     "},
                {"                                                                                                                  ###################  ######                         "},
                {"                                                                                                                            #############                             "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                           ###########                              B                                 "},
                {"                     Q           Q           Q           Q                                                                                                            "},
                {"                  #######     #######     #######     #######                    #########                                                                            "},
                {"                    ### ^^^^^^^ ### ^^^^^^^ ### ^^^^^^^ ###                                                                                                           "},
                {"######################################################################################################################################################################" },
            };

        static string[,] mazeLast = new string[,]
            {
                {"######################################################################################################################################################################"},
                {"                        ######################            #########               ####################             #############################                      "},
                {"                                 ####################   #####                       ###################################             ########                          "},
                {"                                          ###############                                    ########          #############################                          "},
                {"                                                                                            ###########     ###################  ######                               "},
                {"                                                                                                 #############                                                        "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                                                                                      "},
                {"                                                                                                        Y O U  W I N                                                  "},
                {"                                                                                                       --##########--                                                 "},
                {"                                                                                                       --          --                                                 "},
                {"                                                                                                       --          --                                                 "},
                {"                                                                                                       --          --                                                 "},
                {"                                                                                                       --          --                                                 "},
                {"                                                                                                       --          --                                                 "},
                {"                                                                                                       --          --                                                 "},
                {"                                   Q        Q        Q                                                 --          --                                                 "},
                {"                               Q        Q        Q        Q                                            --          --                                                 "},
                {"                                                                                                       --          --                                                 "},
                {"######################################################################################################################################################################" },
            };

        static string[,] leftBuffer = new string[,]
            {
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
            };

        static string[,] rightBufferBackup = new string[,]
            {
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
                {"                             "},
            };

        static int bufferRows = leftBuffer.GetLength(0);
        static int bufferCols = leftBuffer.GetLength(1);
        static string[,] screen = new string[maze1.GetLength(0), maze1.GetLength(1)];
        static string[,] rightBuffer = new string[maze1.GetLength(0), maze1.GetLength(1)];
        static int moveRightCount = 0;
        static int moveLeftCount = 0;
        static int bufferCount = 2;
        static int bufferBackupCount = 0;
        static int pX = 18, pY = 28;

        static char e1Ch1 = (char)174, e1Ch2 = (char)175, e1Ch3 = (char)205, e1Ch4 = (char)206, e1Ch5 = (char)206, e1Ch6 = (char)47, e1Ch7 = (char)92;
        static int e1X = 0, e1Y = 0;

        static char e2Ch1 = 'W', e2Ch2 = (char)19, e2Ch3 = (char)233;
        static int e2X = 0, e2Y = 0;

        static char e3Ch1 = (char)1, e3Ch2 = (char)205, e3Ch3 = (char)216, e3Ch4 = (char)178, e3Ch5 = (char)215, e3Ch6 = (char)182, e3Ch7 = (char)186;
        static int e3X = 0, e3Y = 0;

        static char door = '-';
        static int score = 0;
        static int playerHealth = 100;
        static int enemy1Health = 100;
        static int enemy2Health = 100;
        static int enemy3Health = 100;
        static int playerLives = 3;

        static char enemy1Bullet = (char)27;
        static int enemy1Bullet_X = 0, enemy1Bullet_Y = 0;
        static bool enemy1BulletCheck = false;
        static char enemy2Bullet;
        static int enemy2Bullet_X = 0, enemy2Bullet_Y = 0;
        static char enemy3Bullet;
        static int enemy3Bullet_X = 0, enemy3Bullet_Y = 0;

        static char bullet = (char)22;
        static int[] playerBullet_Xcoord = new int[500] ;
        static int[] playerBullet_Ycoord = new int[500] ;
        static bool[] bulletActiveCheck = new bool[500];
        static bool[] bulletDirectionCheck = new bool[500];
        static int playerBulletCount = 0;

        static char coin = (char)232;
        static int[] coinXcoord = new int[50];
        static int[] coinYcoord = new int[50];
        static int coinCount = 0;


        static void Main(string[] args)
        {
            char option1;
            char option2;
            bool rightKeyPressed = false;
            int rightKeyPressCount = 0;
            bool leftKeyPressed = false;
            int leftKeyPressCount = 0;
            bool upKeyPressed = false;
            bool spaceKeyPressed = false;

            int applyJump1 = 0;
            int applyJump2 = 1;

            bool applyGravity = false;
            int applyGravityCount1 = 0;
            int applyGravityCount2 = 1;

            bool applyBulletCheck1 = false;
            bool applyBulletCheck2 = false;
            int applyBulletCount = 1;
            int applyEnemy1BulletCount = 1;

            bool playerCheck = true;

            for (int x = 0; x < maze1.GetLength(0); x++)
            {
                for (int y = 0; y < maze1.GetLength(1); y++)
                {
                    screen[x,y] = maze1[x,y];
                }
            }

            RemoveCursor();
            Console.Clear();
            PrintHeader1();
            Loading();
            while (true)
            {
                PrintHeader1();
                option1 = MainMenu();
                if (option1 == '1')
                {
                    while (true)
                    {
                        PrintHeader1();
                        option2 = PlayGameMenu();
                        if (option2 == '1')
                        {
                            Console.Clear();
                            PrintScreen();
                            PrintScreenDetails2();
                            PrintPlayer(playerCheck);
                            while (true)
                            {
                                if (Keyboard.IsKeyPressed(Key.RightArrow))
                                {
                                    if ((!rightKeyPressed) && ((ConsoleReader.GetCharAtXY((short)(pX + 3), (short)pY) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX + 3), (short)pY) == coin) || (ConsoleReader.GetCharAtXY((short)(pX + 3), (short)pY) == door)) && ((ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 1)) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 1)) == coin) || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 1)) == door)) && ((ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 2)) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 2)) == coin) || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 2)) == door)))
                                    {
                                        if ((ConsoleReader.GetCharAtXY((short)(pX + 3), (short)pY) == coin) || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 1)) == coin) || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 2)) == coin))
                                        {
                                            SetCoinCoord();
                                        }

                                        MovePlayerRight();
                                        if (moveLeftCount < 30)
                                        {
                                            moveLeftCount++;
                                        }
                                        if (moveRightCount % 165 == 0)
                                        {
                                            SetRightBuffer2();
                                        }
                                        if (bufferBackupCount == 0)
                                        {
                                            moveRightCount++;
                                        }
                                        if (bufferBackupCount > 0)
                                        {
                                            bufferBackupCount--;
                                        }
                                        playerCheck = true;
                                        Console.Clear();
                                        PrintScreen();
                                        PrintScreenDetails2();
                                        RemoveCoin();
                                        PrintPlayer(playerCheck);
                                        if (e1Y != 0)
                                        {
                                            if (enemy1Health > 1)
                                            {
                                                PrintEnemy1();
                                                if (enemy1BulletCheck == false)
                                                {
                                                    SetEnemy1BulletCoord();
                                                    if (pX >= e1X - 40)
                                                    {
                                                        PrintEnemy1Bullet();
                                                    }
                                                }
                                            }
                                        }
                                        EraseEnemy1();
                                        if (e2Y != 0)
                                        {
                                            if (enemy2Health > 1)
                                                PrintEnemy2();
                                        }
                                        EraseEnemy2();
                                        if (e3Y != 0)
                                        {
                                            if (enemy3Health > 1)
                                            {
                                                PrintEnemy3();
                                            }
                                        }
                                        EraseEnemy3();
                                        if (ConsoleReader.GetCharAtXY((short)(pX - 2), (short)(pY + 1)) == door)
                                        {
                                            break;
                                        }
                                        rightKeyPressCount++;
                                    }
                                    if (rightKeyPressCount == 1)
                                    {
                                        rightKeyPressed = true;
                                        rightKeyPressCount = 0;
                                    }
                                }
                                else
                                {
                                    rightKeyPressed = false;
                                }


                                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                                {
                                    if ((moveLeftCount > 0) && (!leftKeyPressed) && ((ConsoleReader.GetCharAtXY((short)pX, (short)pY) == ' ') || (ConsoleReader.GetCharAtXY((short)pX, (short)pY) == coin)) && ((ConsoleReader.GetCharAtXY((short)(pX - 2), (short)(pY + 1)) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX - 2), (short)(pY + 1)) == coin)) && ((ConsoleReader.GetCharAtXY((short)(pX - 1), (short)(pY + 2)) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX - 1), (short)(pY + 2)) == coin)))
                                    {
                                        if ((ConsoleReader.GetCharAtXY((short)pX, (short)pY) == coin) || (ConsoleReader.GetCharAtXY((short)(pX - 2), (short)(pY + 1)) == coin) || (ConsoleReader.GetCharAtXY((short)(pX - 1), (short)(pY + 2)) == coin))
                                        {
                                            SetCoinCoord();
                                        }
                                        MovePlayerLeft();
                                        moveLeftCount--;
                                        bufferBackupCount++;
                                        playerCheck = false;
                                        Console.Clear();
                                        PrintScreen();
                                        PrintScreenDetails2();
                                        RemoveCoin();
                                        PrintPlayer(playerCheck);
                                        if (e1Y != 0)
                                        {
                                            if (enemy1Health > 1)
                                            {
                                                PrintEnemy1();
                                                if (enemy1BulletCheck == false)
                                                {
                                                    SetEnemy1BulletCoord();
                                                    if (pX >= e1X - 40)
                                                    {
                                                        PrintEnemy1Bullet();
                                                    }
                                                }
                                            }
                                        }
                                        EraseEnemy1();
                                        if (e2Y != 0)
                                        {
                                            if (enemy2Health > 1)
                                                PrintEnemy2();
                                        }
                                        EraseEnemy2();
                                        if (e3Y != 0)
                                        {
                                            if (enemy3Health > 1)
                                            {
                                                PrintEnemy3();
                                            }
                                        }
                                        EraseEnemy3();
                                    }
                                    leftKeyPressed = true;
                                }
                                else
                                {
                                    leftKeyPressed = false;
                                }

                                if (Keyboard.IsKeyPressed(Key.UpArrow) && ((ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 2)) != ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 3)) == ' ' && playerCheck == false) || ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 3)) != ' ' || ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) != ' ' || (ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 2)) != ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) == ' ' && playerCheck == true)) && (ConsoleReader.GetCharAtXY((short)pX, (short)pY) == ' ' && ConsoleReader.GetCharAtXY((short)pX, (short)(pY - 1)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY - 1)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY - 1)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY - 1)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)pY) == ' '))
                                {
                                    if (!upKeyPressed)
                                    {
                                        if (ConsoleReader.GetCharAtXY((short)pX, (short)(pY - 4)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY - 4)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY - 4)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY - 4)) == ' ')
                                        {
                                            applyJump1 = 4;
                                        }
                                        else if (ConsoleReader.GetCharAtXY((short)pX, (short)(pY - 3)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY - 3)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY - 3)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY - 3)) == ' ')
                                        {
                                            applyJump1 = 3;
                                        }
                                        else if (ConsoleReader.GetCharAtXY((short)pX, (short)(pY - 2)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY - 2)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY - 2)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY - 2)) == ' ')
                                        {
                                            applyJump1 = 3;
                                        }
                                    }
                                    upKeyPressed = true;
                                }
                                else
                                {
                                    upKeyPressed = false;
                                }

                                if (Keyboard.IsKeyPressed(Key.Backspace))
                                {
                                    break;
                                }

                                if (applyJump1 > 0)
                                {
                                    applyJump2++;
                                    if (applyJump2 % 10000 == 0)
                                    {
                                        ErasePlayer(playerCheck);
                                        PlayerJump();
                                        PrintPlayer(playerCheck);
                                        applyGravityCount1++;
                                        applyJump1--;
                                    }
                                }
                                else if (applyJump1 == 0)
                                {
                                    applyJump2 = 1;
                                    applyGravity = true;
                                }

                                if (applyGravity == true)
                                {
                                    applyGravityCount2++;
                                    if (applyGravityCount2 % 25000 == 0)
                                    {
                                        ErasePlayer(playerCheck);
                                        PlayerGravity(playerCheck);
                                        PrintPlayer(playerCheck);
                                        applyGravityCount1--;
                                    }
                                }
                                else if (applyGravityCount1 == 0)
                                {
                                    applyGravityCount2 = 1;
                                    applyGravity = false;
                                }

                                if (Keyboard.IsKeyPressed(Key.Space))
                                {
                                    if (!spaceKeyPressed)
                                    {
                                        SetBulletCoord(playerCheck);
                                        applyBulletCheck1 = true;
                                        PrintBullet();
                                    }
                                    spaceKeyPressed = true;
                                }
                                else
                                {
                                    spaceKeyPressed = false;
                                }


                                if (applyBulletCheck1 == true)
                                {
                                    applyBulletCount++;
                                    if (applyBulletCount % 5000 == 0)
                                    {
                                        EraseBullet();
                                        MoveBullet(playerCheck);
                                        PrintBullet();
                                        StopBullet();
                                    }
                                }

                                // if (pX >= e1X-40)
                                // {
                                //     applyEnemy1BulletCount++;
                                //     if (applyEnemy1BulletCount % 40000 == 0)
                                //     {
                                //         // eraseEnemy1Bullet();
                                //         moveEnemy1Bullet();
                                //         printEnemy1Bullet();
                                //         // stopEnemy1Bullet();
                                //     }
                                // }
                            }
                        }
                        else if (option2 == '2')
                        {
                            Console.Clear();
                            PrintScreen();
                            PrintScreenDetails3();
                            PrintPlayer(playerCheck);
                            while (true)
                            {
                                if (Keyboard.IsKeyPressed(Key.RightArrow))
                                {
                                    if ((!rightKeyPressed) && ((ConsoleReader.GetCharAtXY((short)(pX + 3), (short)pY) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX + 3), (short)pY) == coin)) && ((ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 1)) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 1)) == coin)) && ((ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 2)) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 2)) == coin)))
                                    {
                                        if ((ConsoleReader.GetCharAtXY((short)(pX + 3), (short)pY) == coin) || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 1)) == coin) || (ConsoleReader.GetCharAtXY((short)(pX + 4), (short)(pY + 2)) == coin))
                                        {
                                            SetCoinCoord();
                                        }

                                        MovePlayerRight();
                                        if (moveLeftCount < 30)
                                        {
                                            moveLeftCount++;
                                        }
                                        if (moveRightCount % 165 == 0)
                                        {
                                            SetRightBuffer1();
                                        }
                                        if (bufferBackupCount == 0)
                                        {
                                            moveRightCount++;
                                        }
                                        if (bufferBackupCount > 0)
                                        {
                                            bufferBackupCount--;
                                        }
                                        playerCheck = true;
                                        Console.Clear();
                                        PrintScreen();
                                        PrintScreenDetails3();
                                        RemoveCoin();
                                        PrintPlayer(playerCheck);
                                        if (e1Y != 0)
                                        {
                                            if (enemy1Health > 1)
                                            {
                                                PrintEnemy1();
                                                if (enemy1BulletCheck == false)
                                                {
                                                    SetEnemy1BulletCoord();
                                                    if (pX >= e1X - 40)
                                                    {
                                                        PrintEnemy1Bullet();
                                                    }
                                                }
                                            }
                                        }
                                        EraseEnemy1();
                                        if (e2Y != 0)
                                        {
                                            if (enemy2Health > 1)
                                                PrintEnemy2();
                                        }
                                        EraseEnemy2();
                                        if (e3Y != 0)
                                        {
                                            if (enemy3Health > 1)
                                            {
                                                PrintEnemy3();
                                            }
                                        }
                                        EraseEnemy3();
                                        rightKeyPressCount++;
                                    }
                                    if (rightKeyPressCount == 1)
                                    {
                                        rightKeyPressed = true;
                                        rightKeyPressCount = 0;
                                    }
                                }
                                else
                                {
                                    rightKeyPressed = false;
                                }


                                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                                {
                                    if ((moveLeftCount > 0) && (!leftKeyPressed) && ((ConsoleReader.GetCharAtXY((short)pX, (short)pY) == ' ') || (ConsoleReader.GetCharAtXY((short)pX, (short)pY) == coin)) && ((ConsoleReader.GetCharAtXY((short)(pX - 2), (short)(pY + 1)) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX - 2), (short)(pY + 1)) == coin)) && ((ConsoleReader.GetCharAtXY((short)(pX - 1), (short)(pY + 2)) == ' ') || (ConsoleReader.GetCharAtXY((short)(pX - 1), (short)(pY + 2)) == coin)))
                                    {
                                        if ((ConsoleReader.GetCharAtXY((short)pX, (short)pY) == coin) || (ConsoleReader.GetCharAtXY((short)(pX - 2), (short)(pY + 1)) == coin) || (ConsoleReader.GetCharAtXY((short)(pX - 1), (short)(pY + 2)) == coin))
                                        {
                                            SetCoinCoord();
                                        }
                                        MovePlayerLeft();
                                        moveLeftCount--;
                                        bufferBackupCount++;
                                        playerCheck = false;
                                        Console.Clear();
                                        PrintScreen();
                                        PrintScreenDetails3();
                                        RemoveCoin();
                                        PrintPlayer(playerCheck);
                                        if (e1Y != 0)
                                        {
                                            if (enemy1Health > 1)
                                            {
                                                PrintEnemy1();
                                                if (enemy1BulletCheck == false)
                                                {
                                                    SetEnemy1BulletCoord();
                                                    if (pX >= e1X - 40)
                                                    {
                                                        PrintEnemy1Bullet();
                                                    }
                                                }
                                            }
                                        }
                                        EraseEnemy1();
                                        if (e2Y != 0)
                                        {
                                            if (enemy2Health > 1)
                                                PrintEnemy2();
                                        }
                                        EraseEnemy2();
                                        if (e3Y != 0)
                                        {
                                            if (enemy3Health > 1)
                                            {
                                                PrintEnemy3();
                                            }
                                        }
                                        EraseEnemy3();
                                    }
                                    leftKeyPressed = true;
                                }
                                else
                                {
                                    leftKeyPressed = false;
                                }

                                if (Keyboard.IsKeyPressed(Key.UpArrow) && ((ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 2)) != ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 3)) == ' ' && playerCheck == false) || ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 3)) != ' ' || ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) != ' ' || (ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 2)) != ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) == ' ' && playerCheck == true)) && (ConsoleReader.GetCharAtXY((short)pX, (short)pY) == ' ' && ConsoleReader.GetCharAtXY((short)pX, (short)(pY - 1)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY - 1)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY - 1)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY - 1)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)pY) == ' '))
                                {
                                    if (!upKeyPressed)
                                    {
                                        if (ConsoleReader.GetCharAtXY((short)pX, (short)(pY - 4)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY - 4)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY - 4)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY - 4)) == ' ')
                                        {
                                            applyJump1 = 4;
                                        }
                                        else if (ConsoleReader.GetCharAtXY((short)pX, (short)(pY - 3)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY - 3)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY - 3)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY - 3)) == ' ')
                                        {
                                            applyJump1 = 3;
                                        }
                                        else if (ConsoleReader.GetCharAtXY((short)pX, (short)(pY - 2)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY - 2)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY - 2)) == ' ' && ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY - 2)) == ' ')
                                        {
                                            applyJump1 = 3;
                                        }
                                    }
                                    upKeyPressed = true;
                                }
                                else
                                {
                                    upKeyPressed = false;
                                }

                                if (Keyboard.IsKeyPressed(Key.Backspace))
                                {
                                    break;
                                }
                                if (applyJump1 > 0)
                                {
                                    applyJump2++;
                                    if (applyJump2 % 10000 == 0)
                                    {
                                        ErasePlayer(playerCheck);
                                        PlayerJump();
                                        PrintPlayer(playerCheck);
                                        applyGravityCount1++;
                                        applyJump1--;
                                    }
                                }
                                else if (applyJump1 == 0)
                                {
                                    applyJump2 = 1;
                                    applyGravity = true;
                                }

                                if (applyGravity == true)
                                {
                                    applyGravityCount2++;
                                    if (applyGravityCount2 % 25000 == 0)
                                    {
                                        ErasePlayer(playerCheck);
                                        PlayerGravity(playerCheck);
                                        PrintPlayer(playerCheck);
                                        applyGravityCount1--;
                                    }
                                }
                                else if (applyGravityCount1 == 0)
                                {
                                    applyGravityCount2 = 1;
                                    applyGravity = false;
                                }

                                if (Keyboard.IsKeyPressed(Key.Space))
                                {
                                    if (!spaceKeyPressed)
                                    {
                                        SetBulletCoord(playerCheck);
                                        applyBulletCheck1 = true;
                                        PrintBullet();
                                    }
                                    spaceKeyPressed = true;
                                }
                                else
                                {
                                    spaceKeyPressed = false;
                                }


                                if (applyBulletCheck1 == true)
                                {
                                    applyBulletCount++;
                                    if (applyBulletCount % 5000 == 0)
                                    {
                                        EraseBullet();
                                        MoveBullet(playerCheck);
                                        PrintBullet();
                                        StopBullet();
                                    }
                                }
                            }
                        }
                        else if (option2 == '4')
                        {
                            break;
                        }
                    }
                }
                else if (option1 == '2')
                {
                    PrintHeader1();
                    Console.WriteLine("\n");
                    Console.WriteLine("\t\t Not Available Yet!!\n");
                    Console.WriteLine("\t\t Press any key to continue...");
                    Console.ReadKey();
                }
                else if (option1 == '3')
                {
                    PrintHeader1();
                    Console.WriteLine("\n");
                    Console.WriteLine("\t\t Not Available Yet!!\n");
                    Console.WriteLine("\t\t Press any key to continue...");
                    Console.ReadKey();
                }
                else if (option1 == '4')
                {
                    return;
                }
            }
        }

        static void PrintScreen()
        {
            string temp = "";
            char wall = (char)178;

            for (int x = 0; x < maze1.GetLength(0); x++)
            {
                for (int y = 0; y < maze1.GetLength(1); y++)
                {
                    if (screen[x, y] == "#")
                    {
                        temp += wall;
                    }
                    else if (screen[x, y] == "Q")
                    {
                        temp += coin;
                    }
                    else if (screen[x, y] == "E")
                    {
                        SetEnemy1Coord(y, x);
                        temp += " ";
                    }
                    else if (screen[x, y] == "T")
                    {
                        SetEnemy2Coord(y, x);
                        temp += " ";
                    }
                    else if (screen[x, y] == "B")
                    {
                        SetEnemy3Coord(y, x);
                        temp += " ";
                    }
                    else
                    {
                        temp += screen[x, y];
                    }
                }
                temp += "\n";
            }
            PrintHeader2();
            Console.ForegroundColor = ConsoleColor.Gray; // Assuming Console.ForegroundColor = ConsoleColor(h, 7) sets the console text color
            Console.SetCursorPosition(0, 10);
            Console.WriteLine(temp);
        }

        static void PrintScreenDetails2()
        {
            Console.ForegroundColor = ConsoleColor.Red; // Assuming Console.ForegroundColor = ConsoleColor(h, 13) sets the console text color
            Console.SetCursorPosition(0, 40);
            Console.WriteLine($"\t SCORE : {score}\t BULLETS REMAINING: {100 - playerBulletCount}\t HEALTH : {playerHealth}\t Soldier HEALTH : {enemy1Health}\t Robo HEALTH : {enemy2Health}\t BOSS HEALTH : {enemy3Health}");
        }

        static void PrintScreenDetails3()
        {
            Console.ForegroundColor = ConsoleColor.Red; // Assuming Console.ForegroundColor = ConsoleColor(h, 13) sets the console text color
            Console.SetCursorPosition(0, 40);
            Console.WriteLine($"\t\t SCORE : {score}\t\t HEALTH : {playerHealth}");
        }

        static void RemoveCoin()
        {
            for (int x = 0; x < coinCount; x++)
            {
                if (coinYcoord[x] != 0)
                {
                    Console.SetCursorPosition(coinXcoord[x], coinYcoord[x]);
                    Console.Write(" ");
                }
            }
        }

        static void SetCoinCoord()
        {
            Console.Beep();

            CheckAndCollectCoin(pX + 3, pY);
            CheckAndCollectCoin(pX + 4, pY + 1);
            CheckAndCollectCoin(pX + 4, pY + 2);
            CheckAndCollectCoin(pX, pY);
            CheckAndCollectCoin(pX, pY + 1);
            CheckAndCollectCoin(pX - 2, pY + 1);
            CheckAndCollectCoin(pX - 1, pY + 2);
            CheckAndCollectCoin(pX + 1, pY + 3);
            CheckAndCollectCoin(pX, pY + 3);
            CheckAndCollectCoin(pX + 2, pY + 2);
            CheckAndCollectCoin(pX + 2, pY);
            CheckAndCollectCoin(pX + 3, pY + 2);
            CheckAndCollectCoin(pX, pY + 2);
            CheckAndCollectCoin(pX + 1, pY + 2);
            CheckAndCollectCoin(pX + 1, pY + 1);
            CheckAndCollectCoin(pX + 1, pY);
            CheckAndCollectCoin(pX + 2, pY + 3);
            CheckAndCollectCoin(pX + 3, pY + 3);
        }

        static void CheckAndCollectCoin(int x, int y)
        {
            if (ConsoleReader.GetCharAtXY((short)x, (short)y) == coin)
            {
                coinXcoord[coinCount] = x;
                coinYcoord[coinCount] = y;
                coinCount++;
                score += 10;
            }
        }

        static void RemoveCursor()
        {
            Console.CursorVisible = false;
        }

        static void SetBulletCoord(bool check)
        {
            if (check == true)
            {
                playerBullet_Xcoord[playerBulletCount] = pX + 4;
                playerBullet_Ycoord[playerBulletCount] = pY + 1;
                bulletActiveCheck[playerBulletCount] = true;
                bulletDirectionCheck[playerBulletCount] = true;
                playerBulletCount++;
            }
            else if (check == false)
            {
                playerBullet_Xcoord[playerBulletCount] = pX - 1;
                playerBullet_Ycoord[playerBulletCount] = pY + 1;
                bulletActiveCheck[playerBulletCount] = true;
                bulletDirectionCheck[playerBulletCount] = false;
                playerBulletCount++;
            }
        }

        static void PrintBullet()
        {
            for (int x = 0; x < playerBulletCount; x++)
            {
                if (bulletActiveCheck[x] == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(playerBullet_Xcoord[x], playerBullet_Ycoord[x]);
                    Console.Write(bullet);
                }
            }
        }

        static void EraseBullet()
        {
            for (int x = 0; x < playerBulletCount; x++)
            {
                if (bulletActiveCheck[x] == true)
                {
                    // if (bulletDirectionCheck[x] == true)
                    // {
                    //     playerBullet_Xcoord[x]--;
                    // }
                    // else if (bulletDirectionCheck[x] == false)
                    // {
                    //     playerBullet_Xcoord[x]++;
                    // }
                    Console.SetCursorPosition(playerBullet_Xcoord[x], playerBullet_Ycoord[x]);
                    Console.Write(" ");
                }
            }
        }

        static void MoveBullet(bool check)
        {
            for (int x = 0; x < playerBulletCount; x++)
            {
                if (bulletActiveCheck[x] == true)
                {
                    if (bulletDirectionCheck[x] == true)
                    {
                        playerBullet_Xcoord[x]++;
                    }
                    else if (bulletDirectionCheck[x] == false)
                    {
                        playerBullet_Xcoord[x]--;
                    }
                }
            }
        }

        static void StopBullet()
        {
            for (int x = 0; x < playerBulletCount; x++)
            {
                if (bulletActiveCheck[x] == true)
                {
                    if (bulletDirectionCheck[x] == true)
                    {
                        if ((ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)(playerBullet_Ycoord[x])) != ' ') || (playerBullet_Xcoord[x] > 165))
                        {
                            EnemyHealthDecrement(x, bulletDirectionCheck[x]);
                            bulletActiveCheck[x] = false;
                            Console.SetCursorPosition(playerBullet_Xcoord[x], playerBullet_Ycoord[x]);
                            Console.Write(" ");
                        }
                    }
                    else if (bulletDirectionCheck[x] == false)
                    {
                        if ((ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] - 1), (short)(playerBullet_Ycoord[x])) != ' ') || (playerBullet_Xcoord[x] == 0))
                        {
                            bulletActiveCheck[x] = false;
                            Console.SetCursorPosition(playerBullet_Xcoord[x], playerBullet_Ycoord[x]);
                            Console.Write(" ");
                        }
                    }
                }
            }
        }

        static void EnemyHealthDecrement(int x, bool direction)
        {
            if (direction == true)
            {
                if ((ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)(playerBullet_Ycoord[x])) == e1Ch1) || (ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e1Ch2) || (ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e1Ch3) || (ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e1Ch5))
                {
                    if (enemy1Health > 0)
                    {
                        enemy1Health -= 20;
                    }
                }
                else if ((ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e2Ch1) || (ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e2Ch2) || (ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e2Ch3))
                {
                    if (enemy2Health > 0)
                    {
                        enemy2Health -= 10;
                    }
                }
                else if ((ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e3Ch1) || (ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e3Ch2) || (ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e3Ch3) || (ConsoleReader.GetCharAtXY((short)(playerBullet_Xcoord[x] + 1), (short)playerBullet_Ycoord[x]) == e3Ch6))
                {
                    if (enemy3Health > 0)
                    {
                        enemy3Health -= 5;
                    }
                }
            }
        }


        static void PrintPlayer(bool check)
        {
            char chR1 = (char)254, chR2 = (char)244, chR3 = (char)219, chR4 = (char)203, chR5 = (char)205, chR6 = (char)245, chR7 = (char)199;
            char chL1 = (char)254, chL5 = (char)179, chL4 = (char)219, chL3 = (char)203, chL2 = (char)205, chL7 = (char)245, chL6 = (char)182;

            if (check == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(pX + 1, pY);
                Console.Write(chR1);
                Console.SetCursorPosition(pX, pY + 1);
                Console.Write(chR2 + chR3 + chR4 + chR5);
                Console.SetCursorPosition(pX, pY + 2);
                Console.Write(chR6 + chR7);
            }
            else if (check == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(pX + 2, pY);
                Console.Write(chL1);
                Console.SetCursorPosition(pX, pY + 1);
                Console.Write(chL2 + chL3 + chL4 + chL5);
                Console.SetCursorPosition(pX + 2, pY + 2);
                Console.Write(chL6 + chL7);
            }
        }

        static void ErasePlayer(bool check)
        {
            if (check == true)
            {
                Console.SetCursorPosition(pX + 1, pY);
                Console.Write(" ");
                Console.SetCursorPosition(pX, pY + 1);
                Console.Write("    ");
                Console.SetCursorPosition(pX, pY + 2);
                Console.Write("  ");
            }
            else if (check == false)
            {
                Console.SetCursorPosition(pX + 2, pY);
                Console.Write(" ");
                Console.SetCursorPosition(pX, pY + 1);
                Console.Write("    ");
                Console.SetCursorPosition(pX + 2, pY + 2);
                Console.Write("  ");
            }
        }

        static void PlayerJump()
        {
            pY = pY - 1;
        }

        static void PlayerGravity(bool check)
        {
            if (check == true)
            {
                if ((ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 3)) == ' ' || ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 3)) == coin) && (ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 3)) == ' ' || ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 3)) == coin) && (ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 2)) == ' ' || ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 2)) == coin) && (ConsoleReader.GetCharAtXY((short)(pX + 2),(short)(pY + 3)) == ' ' || ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) == coin) && (ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 2)) == ' ' || ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 2)) == coin))
                {
                    pY = pY + 1;
                    if (ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 3)) == coin || ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 3)) == coin || ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 2)) == coin || ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) == coin || ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 2)) == coin)
                    {
                        SetCoinCoord();
                    }
                }

                if ((ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 3)) == '^') || (ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 3)) == '^') || (ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 2)) == '^') || (ConsoleReader.GetCharAtXY((short)((short)(pX + 2)), (short)(pY + 3)) == '^') || (ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 2)) == '^'))
                {
                    playerHealth -= 10;
                }
            }
            else if (check == false)
            {
                if ((ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 2)) == ' ' || ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 2)) == coin) && (ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 2)) == ' ' || ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 2)) == coin) && (ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) == ' ' || ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) == coin) && (ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 3)) == ' ' || ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 3)) == coin))
                {
                    pY = pY + 1;
                    if (ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 2)) == coin || ConsoleReader.GetCharAtXY((short)(pX + 1),(short)(pY + 2)) == coin || ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) == coin || ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 3)) == coin)
                    {
                        SetCoinCoord();
                    }
                }

                if ((ConsoleReader.GetCharAtXY((short)pX, (short)(pY + 2)) == '^') || (ConsoleReader.GetCharAtXY((short)(pX + 1), (short)(pY + 2)) == '^') || (ConsoleReader.GetCharAtXY((short)(pX + 2), (short)(pY + 3)) == '^') || (ConsoleReader.GetCharAtXY((short)(pX + 3), (short)(pY + 3)) == '^'))
                {
                    playerHealth -= 10;
                }
            }
        }




        static void MovePlayerRight()
        {
            for (int x = 0; x < maze1.GetLength(0); x++)
            {
                for (int y = 0; y < bufferCols - 1; y++)
                {
                    leftBuffer[x,y] = leftBuffer[x,y + 1];
                }

                leftBuffer[x, bufferCols-1] = screen[x,0];

                for (int y = 0; y < maze1.GetLength(1) - 1; y++)
                {
                    screen[x,y] = screen[x,y + 1];
                }

                screen[x, maze1.GetLength(1) - 1] = rightBuffer[x,0];

                for (int y = 0; y < maze1.GetLength(1) - 1; y++)
                {
                    rightBuffer[x,y] = rightBuffer[x,y + 1];
                }

                if (bufferBackupCount > 0)
                {
                    rightBuffer[x, maze1.GetLength(1) - 1] = rightBufferBackup[x,0];

                    for (int y = 0; y < bufferCols - 1; y++)
                    {
                        rightBufferBackup[x,y] = rightBufferBackup[x,y + 1];
                    }
                }
            }

            for (int x = 0; x < coinCount; x++)
            {
                // if (coinXcoord[x] <= -30)
                // {
                //     coinXcoord[x] = 0;
                //     coinYcoord[x] = 0;
                // }
                if (coinYcoord[x] != 0)
                {
                    coinXcoord[x]--;
                }
            }

        }

        static void MovePlayerLeft()
        {
            for (int x = 0; x < maze1.GetLength(0); x++)
            {
                for (int y = bufferCols - 1; y > 0; y--)
                {
                    rightBufferBackup[x,y] = rightBufferBackup[x,y - 1];
                }

                rightBufferBackup[x,0] = rightBuffer[x, maze1.GetLength(1) - 1];

                for (int y = maze1.GetLength(1) - 1; y > 0; y--)
                {
                    rightBuffer[x,y] = rightBuffer[x,y - 1];
                }

                rightBuffer[x,0] = screen[x, maze1.GetLength(1) - 1];

                for (int y = maze1.GetLength(1) - 1; y > 0; y--)
                {
                    screen[x,y] = screen[x,y - 1];
                }

                screen[x,0] = leftBuffer[x,bufferCols-1];

                for (int y = bufferCols - 1; y > 0; y--)
                {
                    leftBuffer[x,y] = leftBuffer[x,y - 1];
                }
            }
            for (int x = 0; x < coinCount; x++)
            {
                if (coinYcoord[x] != 0)
                {
                    coinXcoord[x]++;
                }
            }

        }


        static void SetRightBuffer1()
        {
            int randCount = RandomFunction(3);
            if (randCount == 1)
            {
                for (int i = 0; i < maze1.GetLength(0); ++i)
                {
                    for (int j = 0; j < maze1.GetLength(1); ++j)
                    {
                        rightBuffer[i,j] = maze1[i,j];
                    }
                }
            }
            else if (randCount == 2)
            {
                for (int i = 0; i < maze1.GetLength(0); ++i)
                {
                    for (int j = 0; j < maze1.GetLength(1); ++j)
                    {
                        rightBuffer[i,j] = maze2[i,j];
                    }
                }
            }
            else if (randCount == 3)
            {
                for (int i = 0; i < maze1.GetLength(0); ++i)
                {
                    for (int j = 0; j < maze1.GetLength(1); ++j)
                    {
                        rightBuffer[i,j] = maze3[i,j];
                    }
                }
            }
        }

        static void SetRightBuffer2()
        {
            if (bufferCount == 1)
            {
                for (int i = 0; i < maze1.GetLength(0); ++i)
                {
                    for (int j = 0; j < maze1.GetLength(1); ++j)
                    {
                        rightBuffer[i,j] = maze1[i,j];
                    }
                }
            }
            else if (bufferCount == 2)
            {
                for (int i = 0; i < maze1.GetLength(0); ++i)
                {
                    for (int j = 0; j < maze1.GetLength(1); ++j)
                    {
                        rightBuffer[i,j] = maze2[i,j];
                    }
                }
            }
            else if (bufferCount == 3)
            {
                for (int i = 0; i < maze1.GetLength(0); ++i)
                {
                    for (int j = 0; j < maze1.GetLength(1); ++j)
                    {
                        rightBuffer[i,j] = maze3[i,j];
                    }
                }
            }
            else if (bufferCount == 4)
            {
                for (int i = 0; i < maze1.GetLength(0); ++i)
                {
                    for (int j = 0; j < maze1.GetLength(1); ++j)
                    {
                        rightBuffer[i,j] = mazeLast[i,j];
                    }
                }
                bufferCount = 0;
            }
            bufferCount++;
        }


        static void SetEnemy1Coord(int x, int y)
        {
            e1X = x;
            e1Y = y + 10;
        }

        static void PrintEnemy1()
        {
            // char e1Ch1 = 174, e1Ch2 = 175, e1Ch3 = 205, e1Ch4 = 206, e1Ch5 = 206, e1Ch6 = 47, e1Ch7 = 92;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(e1X + 1, e1Y);
            Console.Write(e1Ch1 + e1Ch2);
            Console.SetCursorPosition(e1X, e1Y + 1);
            Console.Write(e1Ch3 + e1Ch4 + e1Ch5);
            Console.SetCursorPosition(e1X + 1, e1Y + 2);
            Console.Write(e1Ch6 + e1Ch7);
        }

        static void EraseEnemy1()
        {
            if (e1X < 10 || enemy1Health < 1)
                e1Y = 0;
        }

        static void SetEnemy1BulletCoord()
        {
            enemy1Bullet_X = e1X - 1;
            enemy1Bullet_Y = e1Y + 1;
            enemy1BulletCheck = true;
        }

        static void PrintEnemy1Bullet()
        {
            Console.SetCursorPosition(enemy1Bullet_X, enemy1Bullet_Y);
            Console.Write(enemy1Bullet);
        }

        static void EraseEnemy1Bullet()
        {
            Console.SetCursorPosition(enemy1Bullet_X, enemy1Bullet_Y);
            Console.Write(" ");
        }

        static void MoveEnemy1Bullet()
        {
            enemy1Bullet_X--;
        }

        static void StopEnemy1Bullet()
        {
            if ((ConsoleReader.GetCharAtXY((short)(enemy1Bullet_X - 1), (short)enemy1Bullet_Y) != ' ') || (enemy1Bullet_X < e1X - 45) || (enemy1Bullet_X == 0))
            {
                Console.SetCursorPosition(enemy1Bullet_X, enemy1Bullet_Y);
                Console.Write(" ");
                enemy1Bullet_Y = 0;
                enemy1BulletCheck = false;
            }
        }


        static void SetEnemy2Coord(int x, int y)
        {
            e2X = x;
            e2Y = y + 10;
        }

        static void PrintEnemy2()
        {
            // char e2Ch1 = 'W', e2Ch2 = 19, e2Ch3 = 233;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(e2X, e2Y);
            Console.Write(e2Ch1 + e2Ch1 + " " + e2Ch1 + e2Ch1);
            Console.SetCursorPosition(e2X + 1, e2Y + 1);
            Console.Write(e2Ch1 + e2Ch1 + e2Ch1);
            Console.SetCursorPosition(e2X + 2, e2Y + 2);
            Console.Write(e2Ch2);
            Console.SetCursorPosition(e2X + 2, e2Y + 3);
            Console.Write(e2Ch3);
        }

        static void EraseEnemy2()
        {
            if (e2X < 10 || enemy2Health < 1)
                e2Y = 0;
        }


        static void SetEnemy3Coord(int x, int y)
        {
            e3X = x;
            e3Y = y + 10;
        }

        static void PrintEnemy3()
        {
            // char e3Ch1 = 1, e3Ch2 = 205, e3Ch3 = 216, e3Ch4 = 178, e3Ch5 = 215, e3Ch6 = 182, e3Ch7 = 186;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(e3X + 2, e3Y);
            Console.Write(e3Ch1);
            Console.SetCursorPosition(e3X, e3Y + 1);
            Console.Write(e3Ch2 + e3Ch3 + e3Ch4 + e3Ch5);
            Console.SetCursorPosition(e3X + 2, e3Y + 2);
            Console.Write(e3Ch6);
            Console.SetCursorPosition(e3X + 2, e3Y + 3);
            Console.Write(e3Ch7);
        }

        static void EraseEnemy3()
        {
            if (e3X < 10 || enemy3Health < 1)
                e3Y = 0;
        }


        static void PrintHeader1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                                            _____                                                                 _____ 
                                           ( ___ )                                                               ( ___ )
                                            |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
                                            |   |  _______  _______  _______  _______  ______   _______  _______  |   | 
                                            |   | (  ____ \(  ____ )(  ____ \(  ____ \(  __  \ (  ___  )(       ) |   | 
                                            |   | | (    \/| (    )|| (    \/| (    \/| (  \  )| (   ) || () () | |   | 
                                            |   | | (__    | (____)|| (__    | (__    | |   ) || |   | || || || | |   | 
                                            |   | |  __)   |     __)|  __)   |  __)   | |   | || |   | || |(_)| | |   | 
                                            |   | | (      | (\ (   | (      | (      | |   ) || |   | || |   | | |   | 
                                            |   | | )      | ) \ \__| (____/\| (____/\| (__/  )| (___) || )   ( | |   | 
                                            |   | |/       |/   \__/(_______/(_______/(______/ (_______)|/     \| |   | 
                                            |   |                                                                 |   | 
                                            |   |  _______ _________ _______          _________ _______  _______  |   | 
                                            |   | (  ____ \\__   __/(  ____ \|\     /|\__   __/(  ____ \(  ____ ) |   | 
                                            |   | | (    \/   ) (   | (    \/| )   ( |   ) (   | (    \/| (    )| |   | 
                                            |   | | (__       | |   | |      | (___) |   | |   | (__    | (____)| |   | 
                                            |   | |  __)      | |   | | ____ |  ___  |   | |   |  __)   |     __) |   | 
                                            |   | | (         | |   | | \_  )| (   ) |   | |   | (      | (\ (    |   | 
                                            |   | | )      ___) (___| (___) || )   ( |   | |   | (____/\| ) \ \__ |   | 
                                            |   | |/       \_______/(_______)|/     \|   )_(   (_______/|/   \__/ |   | 
                                            |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
                                           (_____)                                                               (_____)
");
        }

        static void Loading()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(76, 29);
            Console.Write("LOADING");
            Console.SetCursorPosition(55, 30);

            for (int i = 0; i < 25; i++)
            {
                char box = (char)219;
                Console.Write($"{box}{box}");
                Thread.Sleep(30);
            }
        }

        static void PrintHeader2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                                            /==========================================================================\
                                            ||   _______  ___________  ____  __  ___  _______________ _______________ ||
                                            ||  / __/ _ \/ __/ __/ _ \/ __ \/  |/  / / __/  _/ ___/ // /_  __/ __/ _ \||
                                            || / _// , _/ _// _// // / /_/ / /|_/ / / _/_/ // (_ / _  / / / / _// , _/||
                                            ||/_/ /_/|_/___/___/____/\____/_/  /_/ /_/ /___/\___/_//_/ /_/ /___/_/|_| ||
                                            \==========================================================================/
        ");
        }

        static char MainMenu()
        {
            char option;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(53, 27);
            Console.WriteLine("********************************************************");
            Console.SetCursorPosition(53, 28);
            Console.WriteLine("*                 M A I N     M E N U                  *");
            Console.SetCursorPosition(53, 29);
            Console.WriteLine("********************************************************");
            Console.SetCursorPosition(53, 30);
            Console.WriteLine("*                                                      *");
            Console.SetCursorPosition(53, 31);
            Console.WriteLine("*          1-          PLAY  GAME                      *");
            Console.SetCursorPosition(53, 32);
            Console.WriteLine("*------------------------------------------------------*");
            Console.SetCursorPosition(53, 33);
            Console.WriteLine("*          2-         HIGH  SCORES                     *");
            Console.SetCursorPosition(53, 34);
            Console.WriteLine("*------------------------------------------------------*");
            Console.SetCursorPosition(53, 35);
            Console.WriteLine("*          3-         INSTRUCTIONS                     *");
            Console.SetCursorPosition(53, 36);
            Console.WriteLine("*------------------------------------------------------*");
            Console.SetCursorPosition(53, 37);
            Console.WriteLine("*          4-             EXIT                         *");
            Console.SetCursorPosition(53, 38);
            Console.WriteLine("*                                                      *");
            Console.SetCursorPosition(53, 39);
            Console.WriteLine("********************************************************");
            Console.SetCursorPosition(53, 40);
            Console.WriteLine("*                  YOUR OPTION :                       *");
            Console.SetCursorPosition(53, 41);
            Console.WriteLine("********************************************************");

            while (true)
            {
                option = Console.ReadKey().KeyChar;
                if (option == '1' || option == '2' || option == '3' || option == '4')
                {
                    Console.SetCursorPosition(87, 40);
                    Console.Write(option);
                    Thread.Sleep(1000);
                    return option;
                }
            }
        }

        static char PlayGameMenu()
        {
            char option;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(53, 28);
            Console.WriteLine("********************************************************");
            Console.SetCursorPosition(53, 29);
            Console.WriteLine("*                 P L A Y     G A M E                  *");
            Console.SetCursorPosition(53, 30);
            Console.WriteLine("********************************************************");
            Console.SetCursorPosition(53, 31);
            Console.WriteLine("*                                                      *");
            Console.SetCursorPosition(53, 32);
            Console.WriteLine("*           1-           CASUAL                        *");
            Console.SetCursorPosition(53, 33);
            Console.WriteLine("*------------------------------------------------------*");
            Console.SetCursorPosition(53, 34);
            Console.WriteLine("*           2-      UNLIMITED  MODE                    *");
            Console.SetCursorPosition(53, 35);
            Console.WriteLine("*------------------------------------------------------*");
            Console.SetCursorPosition(53, 36);
            Console.WriteLine("*           3-          GO  BACK                       *");
            Console.SetCursorPosition(53, 37);
            Console.WriteLine("*                                                      *");
            Console.SetCursorPosition(53, 38);
            Console.WriteLine("********************************************************");
            Console.SetCursorPosition(53, 39);
            Console.WriteLine("*                  YOUR OPTION :                       *");
            Console.SetCursorPosition(53, 40);
            Console.WriteLine("********************************************************");

            while (true)
            {
                option = Console.ReadKey().KeyChar;

                if (option == '1' || option == '2' || option == '3')
                {
                    Console.SetCursorPosition(87, 39);
                    Console.Write(option);
                    Thread.Sleep(1000);
                    return option;
                }
            }
        }



        void PrintYouWin()
        {

        }

        void PrintYouLoss()
        {

        }

        void ScoreBoard()
        {

        }


        static Random random = new Random();

        static int RandomFunction(int size)
        {
            return random.Next(1, size + 1);
        }

    }


    public class ConsoleReader
    {
        [StructLayout(LayoutKind.Explicit)]
        private struct CHAR_INFO
        {
            [FieldOffset(0)]
            public char UnicodeChar;
            [FieldOffset(2)]
            public short Attributes;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadConsoleOutput(
            IntPtr hConsoleOutput,
            [Out] CHAR_INFO[] lpBuffer,
            COORD dwBufferSize,
            COORD dwBufferCoord,
            ref SMALL_RECT lpReadRegion
        );

        [StructLayout(LayoutKind.Sequential)]
        private struct COORD
        {
            public short X;
            public short Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SMALL_RECT
        {
            public short Left;
            public short Top;
            public short Right;
            public short Bottom;
        }

        public static char GetCharAtXY(short x, short y)
        {
            CHAR_INFO[] buffer = new CHAR_INFO[1];
            COORD bufferSize = new COORD { X = 1, Y = 1 };
            COORD bufferCoord = new COORD { X = 0, Y = 0 };
            SMALL_RECT readRegion = new SMALL_RECT { Left = x, Top = y, Right = x, Bottom = y };

            bool success = ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), buffer, bufferSize, bufferCoord, ref readRegion);

            return success ? buffer[0].UnicodeChar : ' ';
        }

        private const int STD_OUTPUT_HANDLE = -11;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        // Main method or other members go here
    }
}
