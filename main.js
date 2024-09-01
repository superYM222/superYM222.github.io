const clickBtn = document.getElementById('heart');
let clickOpen = false;
clickBtn.addEventListener('click',()=>{
    if(!clickOpen ){
        clickBtn.classList.add('open');
        clickOpen =true;
    }
    else{
        clickBtn.classList.remove('open');
        clickOpen =false;
    }
});