//1 Задача
int[] arr = new int [10];
Random rdm = new Random();

for (int i = 0; i <= 9; i++ ){
    arr[i] = rdm.Next(1,100);
}

int count = 0;

foreach (int item in arr)
{

    if (item > 20 && item < 90) 
    {
        count++;
    }

};

Console.WriteLine(count);
