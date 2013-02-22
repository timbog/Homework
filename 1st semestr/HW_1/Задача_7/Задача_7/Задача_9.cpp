
#include<stdio.h>
int main(int m)
{
scanf("%d",&m);
int k=0;
printf("%d\n",1);
for (int i=1;i<=m;i++)
{
for (int j=1;j<=i;j++)
{
if ((i % j) != 0)
{
	k=k+1;
}
}
if (k==i-2)
{
	printf("%d\n",i);
}
k=0;
}
return 0;
}