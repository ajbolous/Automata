#include <stdio.h>
#include <conio.h>
#include <dos.h>
void interrupt Int8(void);
void interrupt Int9(void);
void SortArr(int NumOfLetters, int ar[]);
void interrupt(*Int8Save) (void);
void interrupt(*Int9Save) (void);
unsigned long counter;
int  arr[200];				// array for the difference between two 9's intterupt
int LetterNum = 0;		// number of letters that pressed by user
char ScanCode = 0;				// scan code of the key
char Letters[200];
int Letter = 0;				//used to know if first letter was pressed or not
int main()
{
	int MaxTime, MinTime, MedTime, TotalTime;
	Int8Save = getvect(8);// save old interrupt 8
	Int9Save = getvect(9);// save old interrupt 9
	setvect(8, Int8);//set new interrupt 8
	setvect(9, Int9);//set new interrupt 9

	/*write value 700 into the latch*/
	asm{
		MOV AL, 36H; TIMER COMMAND : SELECT CHANNEL 0;
	;                READ / WRITE LSB - MSB
		;                MODE 3: BINARY
		OUT 43H, AL
		MOV BX, 700; DESIRED COUNT VALUE FOR 110HZ RESULT
		MOV AL, BL; TRANSFER THE LSB 1ST
		OUT 40H, AL
		MOV AL, BH; TRANSFER THE MSB SECOND
		OUT 40H, AL
	}
	printf("Enter Singal Line Input : \n");
	while (ScanCode != 28)
	{
	   
	}
	printf("timed: \n");
	for (i = 0; i < LetterNum; i++)
		printf("%d", arr[i]);
	SortArray(LetterNum, arr);
	printf("Sorted:\n");
	for (j = 0; j <LetterNum; j++)
		printf(" %d ", arr[j]);
	MaxTime = arr[LetterNum - 1];
	printf("max_time = %d/1096 secs", MaxTime);
	MinTime = arr[0];
	printf("min_time = %d/1096 secs", MinTime);
	MedTime = arr[LetterNum / 2];
	printf("med_time = %d", MedTime);
	for (i = 0; i < LetterNum; i++)
		TotalTime += arr[i];
	printf("total_time = %d/1096 secs", TotalTime);

	setvect(8, Int8Save);
	setvect(9, Int9Save);

	getch();
	return (0);


}
void interrupt Int9(void)// have to check if the key pressed or released !!!!!!!!!!!!!!!!!!!!!!!!!!!!
{
/*to read the keyboard */
	asm{
		IN   AL,60h
		MOV ScanCode, AL
	}

		if (LetterNum > 200)// if the user write more than 200 letters stop the permission for input
			ScanCode = 28;
	/*convert from ascii to char and store the result in Letter's array and prints the letters that pressed */
	if ((int)ScanCode != 28)
	{

		printf("%c", Letters[(int)scanCode]);
		if (Letter != 0)//if it's not the first letter
		{
			arr[LetterNum] = counter;
			LetterNum++;

		}
		Letter++;
		counter = 0;
		
	}
}
void interrupt Int8(void)
{
	counter++;
	Int8Save();
}
void SortArr(int NumOfLetters, int ar [])
{
	int i = 0, j = 0;
	int replace;
	for (i = 0; i < NumOfLetters;i++)
	{ 
		for (j= i+1; j < NumOfLetters; j++)
		{
			if (ar[j] < ar[i])
			{
				replace = ar[i]
					ar[i] = ar[j];
				ar[j] = replace;
			}
		}
	}
}

