#include <stdio.h>
#include <conio.h>

int TimUCLN(int a, int b) {
	int x = a, y = b;
	while(x != y)
		x > y ? x -= y : y -= x;
	return x;
}

int TimUCLNCuaMang(int a[], int n){
	int ucln = a[0];
	for(int i = 1; i < n; i++) {
		ucln = TimUCLN(ucln, a[i]);
	}
	return ucln;
}

int main() {
	int a[] = {1,2,3,4,5};
	int n = 5;
	printf("UCLN cua mang la: %d", TimUCLNCuaMang(a, n));
	
}
