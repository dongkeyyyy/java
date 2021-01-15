package com.kia.Ex1;

public class Ex_1 {
	private String model;
	private String color;
	private String money;
	public final static String JIJUM = "동대구 영업소";

	public Ex_1() {
		model = "k9";
		color = "블랙";
		money = "비쌈";
		System.out.println("기본 생성자 생성!");
		showEx_1Info();
	}

	public Ex_1(String model, int year, String money) {
		super();
		this.model = model;
		this.color = color;
		this.money = money;
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public String getMoney() {
		return money;
	}

	public void setMoney(String money) {
		this.money = money;
	}

	public void showEx_1Info() {
		System.out.println("모델 : " + model);
		System.out.println("색상 : " + color);
		System.out.println("가격 : " + money);
		System.out.println("------------------");
	}

}
