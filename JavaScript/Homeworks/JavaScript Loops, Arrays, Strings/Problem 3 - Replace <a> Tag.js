function solve(arr){
    var regex = /(<a.*? href)=(\'|\"|)(.*?)\2>([^<]+)(<\/a>)/g;
    var str = arr.replace(regex,"[URL_href=$3]$4[/URL]");
    regex = /\s/g;
    str = str.replace(regex, '\n');
    console.log(str.replace('_', ' '));

}
var arr = '<ul>\
 <li>\
 <a href=http://softuni.bg>SoftUni</a>\
 </li>\
 </ul>';
solve(arr);
