package com.kakao.stApp;

import java.util.Random;

public class stAppMain {

	public static void main(String[] args) {
		String name[] = {"ȫ�浿", "��浿", "�ڱ浿", "�̱浿", "�ֱ浿"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'��', '��'};
		String address[] = {"�뱸�� ���� �ž�4��", "����� ���� �ž�4��", "�λ�� ���� �ž�4��", "��õ�� ���� �ž�4��", "���ֽ� ���� �ž�4��"};
		
		Student st[] = new Student[10];
		Random r = new Random();
		for (int i=0; i<st.length; i++) {
			System.out.println("��ȣ" + (i+1));
		st[i] = new Student(name[r.nextInt(5)],
				age[r.nextInt(5)], gender[r.nextInt(2)], address[r.nextInt(5)]);
				st[i].showStudentInfo();
		}

		//1. ���ο� ��ü�� ����
		st[9] = new Student("����ġ", 24, '��', "���� �Ѿ� �αٵθ޻��");
		st[9].showStudentInfo();
		
		//2. ������ ��ü�� ���� (�̱��� ����)
		st[9].setName("����ġ");
		st[9].setAge(24);
		st[9].setGender('��');
		st[9].setAddress("���� �Ѿ� �αٵθ޻��");
		st[9].showStudentInfo();
	}

}
