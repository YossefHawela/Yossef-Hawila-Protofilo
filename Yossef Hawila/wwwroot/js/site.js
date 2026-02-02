function getCookie(name) {
    return document.cookie
        .split('; ')
        .find(row => row.startsWith(name + '='))
        ?.split('=')[1];
}

function hasCookie(name) {
    return document.cookie
        .split('; ')
        .some(c => c.startsWith(name + '='));
}
function SelectLanguage(Lang) {
    document.getElementById("CLanguage").innerHTML = PortfolioModels[Lang].summary;


    document.cookie = "lang=" + Lang + "; path=/; max-age=31536000";
}