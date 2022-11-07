using System;

int[] bigArr = new int[]{6, 5, 23, 7, 19, 33, 16, 76, 11, 42, 67, 10};

int[] evenArr;
int[] unevenArr;

int temp;

for (int i = 0; i < bigArr.Length - 1; i++)
{
    for (int j = i + 1; j < bigArr.Length; j++)
    {
        if (bigArr[i] > bigArr[j])
        {
            temp = bigArr[i];
            bigArr[i] = bigArr[j];
            bigArr[j] = temp;
        }
    }

    if (bigArr[i] % 2 == 0)
    {

    }
}




Console.ReadLine();