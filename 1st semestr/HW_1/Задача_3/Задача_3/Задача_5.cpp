#include<stdio.h>
void InvertArray(int originalArray[], int firstElement, int lastElement)
{
	for (int i = firstElement, j = lastElement-1; i < j; ++i, --j)
	{
		int temp = originalArray[i];
		originalArray[i] = originalArray[j];
		originalArray[j] = temp;
	}
}
int main()
{
	int m = 0;
	int n = 0;
	int a[10];

	scanf("%d", &m);
	scanf("%d", &n);
	
	for (int i = 0; i < 10; i++)
	{
		a[i] = i;
	}

	InvertArray(a, 0, m); 
	InvertArray(a, m, m+n);
	InvertArray(a, 0, m+n);
	for (int i=0; i < 10; i++)
	{
		printf("%d\n", a[i]);
	}
	return 0;
}