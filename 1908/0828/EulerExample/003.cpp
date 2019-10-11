#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

typedef long long int lli;

int main() {
	lli n = 600851475143LL;
	lli t = n, i, mx = 1;
	for (i = 2; i * i <= n; i++) {
		if (t % i == 0) {
			mx = max(mx, i);
			while (t % i == 0) t /= i;
		}
	}
	mx = max(mx, t);
	cout << mx;
	return 0;
}