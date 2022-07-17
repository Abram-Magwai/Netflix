var planName = localStorage.getItem("planName");
if(planName != null) {
    Deselect();

    document.querySelector(`.${planName.toLowerCase()}`).classList.add("active");
    if(planName == "Mobile") {
        document.querySelectorAll(".mob").forEach(mob => mob.classList.add("active"))
    }else if(planName == "Basic") {
        document.querySelectorAll(".bas").forEach(mob => mob.classList.add("active"))
    }else if(planName == "Standard") {
        document.querySelectorAll(".sta").forEach(mob => mob.classList.add("active"))
    }else {
        ocument.querySelectorAll(".pre").forEach(mob => mob.classList.add("active"))
    }
}
function Deselect() {
    document.querySelectorAll(".active").forEach(x => {
        x.classList.remove("active");
    })
}