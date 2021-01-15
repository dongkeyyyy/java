package com.kdh.carApp;

import java.util.Random;

import com.kdh.carApp.car.Car;
import com.kdh.carApp.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {
		String name[] = {"홍길동", "김길동	", "박길동", "이길동", "최길동"};
		String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278", 
						"010-4523-1978", "010-7890-2134"};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", 
							"부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		String model[] = {"Sm6", "쏘나타", "싼타페", "K7", "그랜져"};
		String color[] = {"블랙", "은색", "흰색", "회색", "빨강"};
		int year[] = {2016, 2017, 2016, 2017, 2016};
		String company[] = {"삼성르노", "현대", "현대", "기아", "현대"};
		
		Customer cus[] = new Customer[10];
		Car car[] = new Car[10];
		Random r = new Random();
		
		for (int i = 0; i < 10; i++) {
			cus[i] = new Customer(name[r.nextInt(5)], tel[r.nextInt(5)], address[r.nextInt(5)]);
		}
		
		for (int i = 0; i < 10; i++) {
			car[i] = new Car(model[r.nextInt(5)], color[r.nextInt(5)], year[r.nextInt(5)], company[r.nextInt(5)]);
		}
		
		for (int i = 0; i < 10; i++) {
			cus[i].printCustomerInfo();
			car[i].printCarInfo();
		}
	}

}