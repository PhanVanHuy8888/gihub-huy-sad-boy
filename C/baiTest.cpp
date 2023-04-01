#include<stdio.h>
#include <math.h>

void NhapMang(int arr[], int n) {
	for(int i = 0; i < n; i++) {
		printf("a[%d]= ", i);
		scanf("%d", &arr[i]);
	}
}

void InMang(int arr[], int n) {
	for(int i = 0; i < n; i++) {
		printf("%d ", arr[i]);
	}
}

void CacPhanTuChan(int arr[], int n) {
	for(int i = 0; i < n; i++) {
		if(arr[i] % 2 == 0) {
			printf("%d ", arr[i]);
		}
	}
}

void CacPhanTuChiaHetCho3Hoac5(int arr[], int n) {
	for(int i = 0; i < n; i++) {
		if(arr[i] % 3 == 0 || arr[i] % 5 ==0) {
			printf("%d ", arr[i]);
		}
	}
}





// Bai 8:
int TimSoDoiXung(int arr[], int n) {
	int sum = 0, so;
	for(int i = 0; i < n; i++) {
		so = arr[i];
		int  songc = 0;
		for(int j = so; j != 0; j /= 10){
			songc = songc * 10 + so % 10 ;
		}
		if(so == songc) {
			printf("%d ", so);
			sum += so;			
		}		
	}
	return sum;

}

bool LaChuSo(char kt) {
	return kt >= '0' && kt <= '9';
}

int GhepSo(int so, char k) {
	return so * 10 + k - '0';
}

int DemKyTu(char Arr[]) {
	int m = 0;
	for(int i = 0; Arr[i] != '\0'; i++) {
		m++;
	}
	return m;
}


int TinhS(char Arr[]) {
	int s = 0, m = DemKyTu(Arr), so = 0;
	for(int i = 0; i <= m; i++) {
		if(LaChuSo(Arr[i]))
		so = GhepSo(so, Arr[i]);
		else {
			s += so;
			so = 0;
		}
		
	}
	return s;
}


// Bai 3:
//void InMang(double a[], int n);
//double TinhCanBacHai(int a[],int n);
//void HoanDoiGiaTri(char &x, char &y);
//int TinhTong(int A[], int n, int B[], int m);
//double TinhCan(int n);
//int KiemTraSoNguyen(int n);
//double TimMin(double a[], int n);
//int TimViTri(int a[], int n, int x);


int main() {
	int a = 10;
	double b = 100.5E+2;
	char c = 'x';
	printf("%d \n%.1lf \n%c", a, b, c);
	
	int n;
	printf("\nNhap vao so phan tu cua mang: ");
	scanf("%d", &n);
	
	int arr[n];
	NhapMang(arr,n);
	printf("\nCac phan tu trong mang la: ");
	InMang(arr, n);
	
	printf("\nCac phan tu chan trong mang la: ");
	CacPhanTuChan(arr, n);
	
	printf("\nCac phan tu chia het cho 3 hoac 5 la: ");
	CacPhanTuChiaHetCho3Hoac5(arr, n);
	printf("\n");
	
	printf("\nTong cac so doi xung la: %d", TimSoDoiXung(arr, n));
	
	char Arr[] = {'a', 'b', '1', 'c', '2', '3', 'd', '4', '5', 'e'};
	printf("\nTong cac so duoc tao thanh trong mang la: %d", TinhS(Arr));
	
//	printf("%d ", TimUoc(n));
//	printf("%d", TinhTong(arr, n));

	
	// Bai 4: Chon C.
	// Bai 5: Chon D.
	// Bai 6: Chon A.
	// Bai 7: Chon A.
	
	

}
