Console.Write("Введите x: ");
            int aa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y: ");
            int bb = Convert.ToInt32(Console.ReadLine());
            string check_xy (int x, int y )
            {
                if (x>0 && y>0) return "первая четверть";   
                else if (x>0 && y<0)
                {
                    return "четвертая четверть";
                }
                else if (x<0 && y<0) return "третья четверть";  
                else if (x<0 && y>0) return"вторая четверть";  
                else return "какая то из координат равна нулю";
            }
            Console.WriteLine(check_xy(aa,bb));
