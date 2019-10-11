#include<iostream>
#include<chrono>
#include<cmath>

size_t front(size_t a, size_t lg10) {
	return a / floor(pow(10, lg10));
}
bool isdecal(size_t a, size_t lg10) {
	while (1) {
		if (a == 0)return true;
		else if (a < 10 && lg10>0)return false;
		if (front(a, lg10) == a % 10) {
			return isdecal(static_cast<size_t>((a - front(a, lg10) * pow(10, lg10)) / 10), lg10 - 2 >= 0 ? lg10 - 2 : 0);
		}
		else return false;
	}
}
bool divby33(size_t a) {
	size_t k = 999;
	while (k >= 100 && a >= k * 100) {
		if (a / k < 1000) {
			if (a % k == 0) {
				return true;
			}
		}
		else break;
		k--;
	}
	return false;
}
int main() {
	int cins = 0;
	std::chrono::system_clock::time_point start = std::chrono::system_clock::now();//여기랑
	for (int i = 999999; i > 10000; i--) {
		if (isdecal(i, static_cast<size_t>(log10(i)))) {
			if (divby33(i)) {
				cins = i;
				break;
			}
		}
	}
	std::cout << cins << std::endl;
	std::chrono::system_clock::time_point stop = std::chrono::system_clock::now();//여기 사이에서 시간 측정
	std::chrono::duration<double, std::milli> d = stop - start;
	std::cout << "\n 경과시간 : " << d.count() << " milliseconds" << std::endl;

	std::cin >> cins;

}