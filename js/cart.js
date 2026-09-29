let user = localStorage.getItem("loginUser")

if(!user){
alert("Vui lòng đăng nhập để xem giỏ hàng")
window.location.href = "../baomat/login.html"
}

function loadCart(){

let cart = JSON.parse(localStorage.getItem("cart")) || []
let cartList = document.getElementById("cart-list")

if(cart.length === 0){

cartList.innerHTML = `<div class="empty-cart">Giỏ hàng đang trống</div>`
document.getElementById("cart-total").innerHTML = ""
return

}

cartList.innerHTML = ""

cart.forEach((item,index)=>{

cartList.innerHTML += `

<div class="cart-item">

<input type="checkbox" class="cart-check" onchange="updateTotal()">

<img src="${item.image}">

<div class="cart-info">
<div class="cart-name">${item.name}</div>
<div class="cart-price">${item.price.toLocaleString()} ₫</div>
</div>

<div class="qty-box">

<button class="qty-btn" onclick="changeQty(${index},-1)">-</button>

<div class="qty-num">${item.qty}</div>

<button class="qty-btn" onclick="changeQty(${index},1)">+</button>

</div>

<button class="cart-remove" onclick="removeItem(${index})">
Xóa
</button>

</div>

`

})

updateTotal()

}

function changeQty(index,change){

let cart = JSON.parse(localStorage.getItem("cart")) || []

cart[index].qty += change

if(cart[index].qty < 1){
cart[index].qty = 1
}

localStorage.setItem("cart",JSON.stringify(cart))

loadCart()

// cập nhật số icon giỏ hàng
if(typeof updateCartCount === "function"){
updateCartCount()
}

}

function removeItem(index){

let confirmDelete = confirm("Bạn có chắc chắn muốn xóa sản phẩm này khỏi giỏ hàng không?")

if(!confirmDelete){
return
}

let cart = JSON.parse(localStorage.getItem("cart")) || []

cart.splice(index,1)

localStorage.setItem("cart",JSON.stringify(cart))

loadCart()

if(typeof updateCartCount === "function"){
updateCartCount()
}

}

function updateTotal(){

let cart = JSON.parse(localStorage.getItem("cart")) || []
let checks = document.querySelectorAll(".cart-check")

let total = 0

checks.forEach((check,i)=>{

if(check.checked){

total += cart[i].price * cart[i].qty

}

})

document.getElementById("cart-total").innerHTML =
"Tổng tiền: " + total.toLocaleString() + " ₫"

}

function checkout(){

let cart = JSON.parse(localStorage.getItem("cart")) || []
let checks = document.querySelectorAll(".cart-check")

let selectedItems = []

checks.forEach((check,i)=>{

if(check.checked){

selectedItems.push(cart[i])

}

})

if(selectedItems.length === 0){

alert("Vui lòng chọn sản phẩm")
return

}

localStorage.setItem("orderItems",JSON.stringify(selectedItems))

window.location.href = "order.html"

}


document.getElementById("site-year").textContent =
new Date().getFullYear()

loadCart()