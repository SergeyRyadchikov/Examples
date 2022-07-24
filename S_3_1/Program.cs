Console.Write("Введите x: ");
            int aa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y: ");
            int bb = Convert.ToInt32(Console.ReadLine());
            void check_xy (int x, int y )
            {
                if (x>0 && y>0) Console.WriteLine("первая четверть");   
                else if (x>0 && y<0)
                {
                    Console.WriteLine("четвертая четверть");
                }
                else if (x<0 && y<0) Console.WriteLine("третья четверть");  
                else if (x<0 && y>0) Console.WriteLine("вторая четверть");  
                else Console.WriteLine("какая то из координат равна нулю");
            }
            check_xy(aa,bb);
