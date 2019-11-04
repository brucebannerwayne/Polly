#include<stdio.h>
#include<string.h>
#include<iostream>
#include<string>
using namespace std;
char *action[16][8] = { 
NULL,NULL,NULL,NULL,"S4#",NULL,"S5#",NULL,
"S6#","S7#",NULL,NULL,NULL,NULL,NULL,"acc",
"r4#","r4#","S8#","S9#",NULL,"r4#",NULL,"r4#",
"r7#","r7#","r7#","r7#",NULL,"r7#",NULL,"r7#",
NULL,NULL,NULL,NULL,"S4#",NULL,"S5#",NULL,
"r9#","r9#","r9#","r9#",NULL,"r9#",NULL,"r9#",
NULL,NULL,NULL,NULL,"S4#",NULL,"S5#",NULL,
NULL,NULL,NULL,NULL,"S4#",NULL,"S5#",NULL,
NULL,NULL,NULL,NULL,"S4#",NULL,"S5#",NULL,
NULL,NULL,NULL,NULL,"S4#",NULL,"S5#",NULL,
"S6#","S7#",NULL,NULL,NULL,"S15#",NULL,NULL,
"r2#","r2#","S8#","S9#",NULL,"r2#",NULL,"r2#",
"r3#","r3#","S8#","S9#",NULL,"r3#",NULL,"r3#",
"r5#","r5#","r5#","r5#",NULL,"r5#",NULL,"r5#",
"r6#","r6#","r6#","r6#",NULL,"r6#",NULL,"r6#",
"r8#","r8#","r8#","r8#",NULL,"r8#",NULL,"r8#"
};
int goto1[16][3] = { 1,2,3,
0,0,0,
0,0,0,
0,0,0,
10,2,3,
0,0,0,
0,11,3,
0,12,3,
0,0,13,
0,0,14,
0,0,0,
0,0,0,
0,0,0,
0,0,0,
0,0,0,
0,0,0
};
char vt[8] = {'+','-','*','/','(',')','n','#' };
char vn[3] = { 'E','T','F' };
char *LR[9] = { "E:->E#","E->E+T#","E->E-T#","E->T#","T->T*F#","T->T/F#","T->F#","F->(E)#","F->n#" };
string LR1(char *LR);
int a[30];
char b[30], c[30], c1;
int top1, top2, top3, top, m, n;

void main()
{
	int g, h, i, j, k, l, p, y, z, count;
	char x, copy[100];
	char copy2[100] = {};
	string copy1(copy2);
	top1 = 0; top2 = 0; top3 = 0; top = 0;
	a[0] = 0; y = a[0]; b[0] = '#';
	count = 0; z = 0;

	printf("«Î ‰»Î±Ì¥Ô Ω\n");
	do {
		scanf("%c", &c1);
		c[top3] = c1;
		
	} while (c1 != '#');

	printf("≤Ω÷Ë\t◊¥Ã¨’ª\t\t∑˚∫≈’ª\t\t ‰»Î¥Æ\t\tACTION\tGOTO\n");
	do {
		y = z; m = 0; n = 0;
		g = top; j = 0; k = 0;
		x = c[top];
		count++;
		printf("%d\t", count);

		while (m <= top1)
		{
			printf("%d", a[m]);
			m = m + 1;
		}

		printf("\t\t");
		while (n <= top2)
		{
			printf("%c", b[n]);
			n = n + 1;
		}

		printf("\t\t");
		while (g <= top3)
		{
			printf("%c", c[g]);
			g = g + 1;
		}

		printf("\t\t");
		while (x != vt[j] && j <= 8) 
			j++;

		if (j == 8 && x != vt[j])
		{
			printf("error\n");
			return;
		}

		if (action[y][j] == NULL) {
			printf("error\n");
			return;
		}
		else
			strcpy(copy, action[y][j]);


		if (copy[0] == 'S')
		{
			z = copy[1] - '0';
			top1 = top1 + 1;
			top2 = top2 + 1;
			a[top1] = z;
			b[top2] = x;
			top = top + 1;
			i = 0;
			while (copy[i] != '#')
			{
				printf("%c", copy[i]);
				i++;
			}
			printf("\n");
		}

		if (copy[0] == 'r')
		{
			i = 0;
			while (copy[i] != '#')
			{
				printf("%c", copy[i]);
				i++;
			}
			h = copy[1] - '0';

			copy1 = LR[h - 1];
			while (copy1[0] != vn[k]) 
				k++;
			l = strlen(LR[h - 1]) - 4;
			top1 = top1 - l + 1;
			top2 = top2 - l + 1;
			y = a[top1 - 1];
			p = goto1[y][k];
			a[top1] = p;
			b[top2] = copy1[0];
			z = p;
			printf("\t");
			printf("%d\n", p);
		}

	} while (action[y][j] != "acc");
	printf("acc\n");
	while(1);
	system("pause");
	return;
}
