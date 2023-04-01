#include<stdio.h>
#include <math.h>

int TimMin(int a, int b, int c) {
	if(a < b && a < c) return a;
	else if(b < a && b < c) return b;
	else if(c < a && c < b) return c;
}

int Fibo(int n) {
	if(n < 0) return -1;
	else if(n == 0 || n == 1) return n;
	else return Fibo(n - 1) + Fibo(n - 2);
}

int main() {
	int a = 20, b = 5, c = 10;
	int n = -10;
	printf("So nho nhat la: %d", TimMin(a, b, c));
	printf("\nSo Fibo la: %d", Fibo(n));
}
