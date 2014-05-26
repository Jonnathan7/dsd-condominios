<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<link rel="stylesheet" href="https://netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js" type="text/javascript"></script>
    <script src="https://netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js" type="text/javascript"></script>
</head>
<body>
<div class="container">
<form class="form-horizontal" name"Residente" action="<%=request.getContextPath()%>/ResidenteServlet?opcion=2" method="post">
      <legend>RGISTRO DE RESIDENTES</legend>
        <div class="form-group">
          <label for="txtNombre" class="col-lg-2 control-label">Nombres</label>
          <div class="col-lg-10">
            <input class="form-control" id="txtNombre" name="txtNombre" placeholder="Nombres" type="text" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtApellidos" class="col-lg-2 control-label">Apellidos</label>
          <div class="col-lg-10">
              <input class="form-control" id="txtApellidos" name="txtApellidos" placeholder="Apellidos" type="text" required>
          </div>
        </div>
        <div class="form-group">
          <label class="col-lg-2 control-label" for="txtNuDocumento">Tipo de Documento</label>
          <div class="col-lg-10">
          <select id="txtNuDocumento" name="txtNuDocumento" class="form-control" required>
            <option value="1" >DNI</option>
				    <option value="2" >CARNET EXTRANJERIA</option>
          </select>
        </div>
        </div>
        <div class="form-group">
          <label for="txtNombre" class="col-lg-2 control-label">N�mero de Documento</label>
          <div class="col-lg-10">
            <input class="form-control" id="txtNombre" name="txtNombre" placeholder="N�mero de Documento" type="text" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtFeNac" class="col-lg-2 control-label">Fecha de nacimiento</label>
          <div class="col-lg-10">
            <input class="form-control" id="txtFeNac" name="txtFeNac" placeholder="Fecha de nacimiento" type="date" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtCorreo" class="col-lg-4 control-label">Correo</label>
          <div class="col-lg-10">
            <input class="form-control" id="txtCorreo" name="txtCorreo" placeholder="Correo" type="email" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtClave" class="col-lg-4 control-label">Contrase�a</label>
          <div class="col-lg-10">
            <input class="form-control" id="txtClave" name="txtClave" placeholder="Contrase�a" type="password" required>
          </div>
        </div>
        <div class="form-group"></div>
        <div class="form-group">
          <div class="col-lg-offset-2 col-lg-10">
            <button type="submit" class="btn btn-default">Entrar</button>
          </div>
        </div>
      </form>
</div>
</body>
</html>