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

    console.log(SettingsModels);

    document.getElementById("ContentDiv").dir = Directions[SettingsModels[Lang].direction];
    document.getElementById("HeaderH1").innerHTML = PortfolioModels[Lang].name;
    document.getElementById("SummaryParagraph").innerHTML = PortfolioModels[Lang].summary;

    document.cookie = "lang=" + Lang + "; path=/; max-age=31536000";
}