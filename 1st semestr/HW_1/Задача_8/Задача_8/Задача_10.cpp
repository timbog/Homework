
#include<stdio.h>
int main()
{
	int k = 0;
	int a[10];

	for (int i = 0; i < 10; i++)
	{
		scanf("%d",&a[i]);
		if (a[i] == 0)
		{
			++k;
		}
	}

	printf("%d\n",k);
	return 0;
}