#include <iostream>
using namespace std;

int main() {
    int n;
    cout << "Enter a positive integer: ";
    cin >> n;

    if (n > 0) {
        int sum = n * (n + 1) / 2;  // Using the formula
        cout << "Sum of the first " << n << " natural numbers is: " << sum << endl;
    } else {
        cout << "Please enter a positive integer!" << endl;
    }

    return 0;
}
