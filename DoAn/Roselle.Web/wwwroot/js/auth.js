function checkLogin(){

let user = localStorage.getItem("loginUser")
let userArea = document.getElementById("user-area")

if(!userArea) return

let basePath = ""

// nếu đang ở trong menu hoặc app thì lùi 1 cấp
if(
window.location.pathname.includes("/menu/") ||
window.location.pathname.includes("/app/")
){
basePath = "../"
}

// nếu đã đăng nhập
if(user){

userArea.innerHTML = `
<a href="${basePath}app/cart.html" class="cart-icon">
  🛒
  <span id="cart-count">0</span>
</a>

<div class="user-dropdown">
<span class="user-name">Xin chào, ${user}</span>

<div class="dropdown-menu">
<a href="${basePath}app/profile.html">Thông tin cá nhân</a>
<a href="../app/history.html">Lịch sử đặt hàng</a>
<a href="#" onclick="logout()">Đăng xuất</a>
</div>
</div>
`

updateCartCount()
}else{

// nếu chưa đăng nhập
userArea.innerHTML = `
<a href="${basePath}baomat/register.html"><button class="btn">Đăng ký</button></a>
<a href="${basePath}baomat/login.html"><button class="btn">Đăng nhập</button></a>
`

}

}

function logout(){
localStorage.removeItem("loginUser")
location.reload()
}

document.addEventListener("DOMContentLoaded",checkLogin)

function updateCartCount(){

let cart = JSON.parse(localStorage.getItem("cart")) || []

let count = 0

cart.forEach(item=>{
count += item.qty || 1
})

let badge = document.getElementById("cart-count")

if(badge){
badge.textContent = count
}

}
updateCartCount()