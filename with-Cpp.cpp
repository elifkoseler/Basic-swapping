#include <iostream>
using namespace std;

int main(){
	int a, b;
	while(true){
	cout<<"Please enter a: "<<endl;
	cin>>a;
	cout<<"Please enter b: "<<endl;
	cin>>b;
	
	a = a + b;
	b = a - b;
	a = a - b; //actually it becomes sum - difference between two variable
	cout<<"a: "<<a<<" b: "<<b<<endl;
	cout<<endl;
}
}
