#include<stdio.h>
#include<string.h>
int main()
{
	int k = 1;
	char *str = new char[10];
	printf("Enter string:");
	scanf("%s",str);

	for (int i = 0; i < strlen(str); ++i)
	{
		if (str[i] == '(')
		{
			k = k + 1;
		}
		if (str[i]==')')	
		{
			k = k - 1;
		}
		if (k == 0)
			break;
	}

	if (k==1)
	{
		printf("true");
	}
	else
	{
		printf("false");
	}
	return 0;
}