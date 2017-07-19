#include <vector>
#include <algorithm>
using namespace std;

class Center {
private:
	int num; //�߰�� ��ȣ
	int latitude, longitude; //�߰���� ����,�浵
	vector<Drone> drone;
	int droneNum; //�߰���� ��� ���� (drone.size)
	int coverRange;

public:
	void upgradeDroneNum(); //���� event���� ���� �ð����� �ٲ� �� Center�� dronenum ���׷��̵�

};

class CenterManager {


};

class Drone {
private:
	int num; //��� ��ȣ
	int drivable_dist; //���� ���� �� ���డ�ɰŸ�(����� ����)
	int chargingTime; //���� �������� �ɸ��� �ð�
	int battery; //����� ���͸� ������

public:
	void upgradeDroneBattery(); //�� ����� ���͸� ���׷��̵�

};


vector<Center> center;

class Event {
private:
	int latitude, longitude; //event �߻� ��ġ
	int time[5]; //event �߻� �ð�

public:
	bool operator > {
		//��� �߻� �ð��� ���ϴ� ������
	};
	
	int findCenter(); // �߰�Ҹ� ���� input: center, latitude, longitude , output: coverange�� �Ÿ����� ū �߰�� ��ȣ���� ����� ������� �迭�� ���
	int findDrone(); //�⵿�� ����� ã�´�(��а���, ���͸� ���) input:findCenter()���� ���� �迭, center , return: [�߰�� ��ȣ, ��� ��ȣ]
	int timeToDest(); //���������� �ɸ��� �ð� input:�߰�� ��ġ, event �߻���ġ, return: �ð�(sec)
	
};

vector<Event> event_;

void simulation(int starttime[5], int endtime[5]) {
	// �ùķ��̼� ����, �� �ð��� �迭�� [��, ��, ��, �ð�, ��]�� �޴´�
	range = findEventRange(event_, starttime[5], endtime[5]);
	/* range�� �ִ� event�� ���ʷ� ����
	[CenterNum, DroneNum] = FindDrone()
	t = Center ��ġ�� ��� �߻� ��ġ�� �޾ƿͼ� �����̰� ���� ���� �ð��� ����
	output: [eventNum, t, isSuccessful]

	���� �� �߰���� upgradeDroneNum, upgradeDroneBattery
	*/
};

int findEventRange(event_, int starttime[5], endtime[5]) {
	//starttime~endtime �ȿ� ������ event�� ���� return

};

void main() {

	sort(event_);
	startTime = [];
	endTime = [];
	simulation(startTime, endTime);

}