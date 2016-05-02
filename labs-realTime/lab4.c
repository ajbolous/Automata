/* readyear.c */

#include <stdio.h>
#include <conio.h>
#include <string.h>
typedef struct time
{
	int hour;
	int min;
	int sec;
	int status;
	char msg[200];
} TIME;


int  convert_to_binary(int x)
{
	int i;
	int temp, scale, result;


	temp = 0;
	scale = 1;
	for (i = 0; i < 4; i++)
	{
		temp = temp + (x % 2)*scale;
		scale *= 2;
		x = x >> 1;
	} // for

	result = temp;
	temp = 0;

	scale = 1;
	for (i = 0; i < 4; i++)
	{
		temp = temp + (x % 2)*scale;
		scale *= 2;
		x = x >> 1;
	} // for

	temp *= 10;
	result = temp + result;
	return result;

} // convert_to_binary
void ChangeClock(TIME alarms[],  int Nhour, int Nmin, int Nsec,int NumOfReminders)
{
	
	char ScanCode;
	int i;
	int CountReminders[3];
	for (i = 0; i < 3; i++)
		CountReminders[i] = 1;

	/*initialize the array of time struct*/
	for (i = 0; i < NumOfReminder; i++)
	{
	if((alarms[i].hour==Nhour)&&(alarms[i].min==Nmin)&&(alarms[i].sec==Nsec)&&(alarms[i].status==1))

	
	}
	printf("Enter either t for Terminate or r for Request alarm:r\n");
	asm
	{
		IN   AL,60h
		MOV ScanCode, AL
	}
		if (ScanCode == 't')
		{
			//terminte
		}
	if (ScanCode == 'r')
	{
		printf("Enter alarm time(hour:min:sec): ");
		scanf("%d:%d:%d\n", hour,min,sec);
		printf("Enter alarm message: ");
		scanf("%s", str);
		asm{
			PUSH AX
			MOV AL,4
			OUT 70h,AL
			MOV AL,84h
			OUT 70h,AL
			MOV AL,BYTE PTR hour
			OUT 71h,AL
			IN AL,70h
			;
		MOV AL, 2
			OUT 70h, AL
			MOV AL, 84h
			OUT 70h, AL
			MOV AL, BYTE PTR min
			OUT 71h, AL
			IN AL, 70h
			;
		MOV AL, 0
			OUT 70h, AL
			MOV AL, 84h
			OUT 70h, AL
			MOV AL, BYTE PTR sec
			OUT 71h, AL
			IN AL, 70h
			;
		POP AX
		} // asm

		sec = convert_to_binary(sec);
		min = convert_to_binary(min);
		hour = convert_to_binary(hour);

		sprintf(str, "%2d:%2d:%2d", hour, min, sec);



	}
}
void readclk(char str[])
{
	int i;
	int hour, min, sec;


	hour = min = sec = 0;

	asm{
		PUSH AX
		MOV AL,0
		OUT 70h,AL
		IN AL,71h
		MOV BYTE PTR sec,AL
		;
	MOV AL,2
		OUT 70h,AL
		IN AL,71h
		MOV BYTE PTR min,AL
		;
	MOV AL,4
		OUT 70h,AL
		IN AL,71h
		MOV BYTE PTR hour,AL
		;
	POP AX
	} // asm

	sec = convert_to_binary(sec);
	min = convert_to_binary(min);
	hour = convert_to_binary(hour);

	sprintf(str, "%2d:%2d:%2d", hour, min, sec);

} // readclk

int main()
{
	char str[16];
	int flag = 1;

	while (flag)
	{
		putchar(13);
		readclk(str);
		printf(str);
		asm{
			PUSH AX
			MOV AH,1
			INT 16h
			PUSHF
			POP AX
			AND AX,64 /* isolate zf */
			MOV flag,AX
			POP AX

		} // asm

	} // while


	asm{
		PUSH AX
		MOV AH,0
		INT 16h
		POP AX
	}  // asm


}  // main
