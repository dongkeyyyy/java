<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h2>숫자 값을 입력하세요.</h2>
	<!--
	<form method="pot" action="calc/ifTestPro.jsp">
	<input type="text" name="number">
	<input type="submit" value="입력 완료">
	</form>
	-->  
	<!-- 실행할경우 인풋박스에 입력한감을 number 변수에 저장 후 ifTestPro.jsp 파일로 넘겨준다 -->
	
	<!-- 
	<form method="post" action="/control0318/calc/ifTestPro.jsp">
	<input type="text" name="number">
	<input type="submit" value="입력 완료">
	</form>
	 -->
	   
	<form method="post" action="http://localhost:8080/control0318/ifTestForm.jsp">
	<input type="text" name="number">
	<input type="submit" value="입력 완료">
	</form>
	</body>
</html>