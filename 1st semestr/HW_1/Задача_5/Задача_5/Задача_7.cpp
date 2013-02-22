#include<stdio.h>
#include<string.h>
#include<conio.h>
int main()
{
int k=0;
int p=0;
const char *str = "(())()";
for (int i=0;i<strlen(str);++i)
{
	if (str[i]=='(')
{
k=k+1;
}
if (str[i]==')')	
{
p=p+1;
}
}
if (k==p)
{
printf("true");
}
else
{
printf("false");
}
getch();
return 0;
}