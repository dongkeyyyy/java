<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

<%
request.setCharacterEncoding("utf-8");
%>
	<jsp:useBean id="testBean" class="javabean0319.Testbean">
		<jsp:setProperty name="testBean" property="name" />
	</jsp:useBean>
	
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h2>
		입력된 이름 : <jsp:getProperty property="name" name="testBean"/>
	</h2>
</body>
</html>