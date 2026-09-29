const userArea=document.getElementById("user-area")

let login=localStorage.getItem("login")

if(login==="true"){

let user=JSON.parse(localStorage.getItem("user"))

userArea.innerHTML=`

<span>Xin chào, ${user.fullname}</span>
<button onclick="logout()" class="btn">Đăng xuất</button>

`

}

function logout(){

localStorage.removeItem("login")

location.reload()

}

let user=localStorage.getItem("loginUser")

if(user){

document.getElementById("user-area").innerHTML=
`
<span>Xin chào, ${user}</span>
<button class="btn" onclick="logout()">Đăng xuất</button>
`

}

function logout(){

localStorage.removeItem("loginUser")
location.reload()

}

