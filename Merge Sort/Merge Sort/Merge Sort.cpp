// Merge Sort.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

void merge(int *, int, int, int);
void mergeSort(int *a, int low, int high){
	int mid;
	if (high > low){
		mid = (low + high) / 2;
		mergeSort(a, low, mid);
		mergeSort(a, mid + 1, high);
		merge(a, low, high, mid);
	}
}

void merge(int *a, int low, int high, int mid){
	int i, j, k,c[50];
	i = low;
	k = low;
	j = mid + 1;
	while (i <= mid && j <= high){
		if (a[i] < a[j]){
			c[k] = a[i];
			k++;
			i++;
		}
		else {
			c[k] = a[j];
			k++;
			j++;
		}
	}
	while (i <= mid) {
		c[k] = a[i];
		k++;
		i++;
	}
	while (j <= high) {
		c[k] = a[j];
		k++;
		j++;
	}
	for (i = low; i < k; i++){
		a[i] = c[i];
	}
}

int _tmain(int argc, _TCHAR* argv[])
{
	int a[5] = {8,10,1,7,2};
	for (int i = 0; i < 5; i++){
		cout << a[i] << endl;
	}
	mergeSort(a, 0, 4);
	for (int i = 0; i < 5; i++){
		cout << a[i] << endl;
	}
	cout << "Hello world" << endl;
	return 0;
}

