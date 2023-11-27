//**************************************1 Задача

/*int[] arr = new int [10];
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

Console.WriteLine($"В массиве {count} элементов лежат в диапозоне от 20 до 90");

//*************************************Задача 2
int[] arr = new int [10];
Random rdm = new Random();

for (int i = 0; i <= 9; i++ ){
    arr[i] = rdm.Next(1,10);
}

int count = 0;

foreach (int item in arr)
{

    if (item % 2 == 0) 
    {
        count++;
    }
};

Console.WriteLine($"В массиве {count} четных элемента(ов)");*/

//Задача 3
double[] arr = new double [10];
Random rdm = new Random();

for (int i = 0; i <= arr.Length - 1; i++ ){
    arr[i] = rdm.NextDouble();
}

double numMin = arr[0];
double numMax = arr[0];

for (int i = 0; i <= arr.Length - 1; i++) {
    if (arr[i] > numMax) {
        numMax = arr[i];
    }
    if (arr[i] < numMin) {
        numMin = arr[i];
    }
}

double result = numMax - numMin;

Console.WriteLine($" Разница между максимальным и минимальным элементом в массиве = {result}");
