#include <iostream>
#include <string>

using namespace std;

int main()
{
	double sum = .0;
	double count = 0;

	for (int i = 0; i < 20; i++)
	{
		string name, grade;
		double score;
		cin >> name >> score >> grade;

		if (grade == "P")
			continue;

		if(grade == "A+")
			sum += (score * 4.5);
		else if (grade == "A0")
			sum += (score * 4.0);
		else if (grade == "B+")
			sum += (score * 3.5);
		else if (grade == "B0")
			sum += (score * 3.0);
		else if (grade == "C+")
			sum += (score * 2.5);
		else if (grade == "C0")
			sum += (score * 2.0);
		else if (grade == "D+")
			sum += (score * 1.5);
		else if (grade == "D0")
			sum += (score * 1.0);
		else if (grade == "F")
			sum += (score * 0.0);

		count += score;
	}

	printf("%.6lf", sum / count);

	return 0;
}