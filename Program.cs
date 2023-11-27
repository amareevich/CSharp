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

//****************************************Задача 3

/*double[] arr = new double [10];
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

Console.WriteLine($" Разница между максимальным и минимальным элементом в массиве = {result}");*/

//*********************************Задача 4

Random rdm = new Random();
int num = rdm.Next(1,100000);
string str = Convert.ToString(num);
int[] arr = new int[str.Length];

for (int i = 0; i <= str.Length - 1; i++) {
    string elem = Convert.ToString(str[i]);
    arr[i] = Convert.ToInt32(elem);
}

foreach (int elem in arr) {
    Console.WriteLine(elem);
}

for (int i = 0; i <= arr.Length - 1; i++) {
    for (int j = 0; j <= arr.Length - 1; j++) {
        int number = arr[j];
        if (arr[j] < arr[i]) {
            arr[j] = arr[i];
            arr[i] = number;
        }
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

foreach (int elem in arr) {
    Console.WriteLine(elem);
}

