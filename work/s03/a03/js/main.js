(function () {
    'use strict';


    fetch('data/1081.json')
        .then((response) => {
            return response.json();
        })
        .then((myJson) => {
            console.log(myJson);
        });

    document.getElementById('getSchool').addEventListener("click", getData);

    function getData() {
        fetch('data/1290.json')
            .then((res) => res.json())
            .then((data) => {
                let output = '<h2>Schools</h2>';
                data.Skolenheter.forEach(function (school) {
                    output += `
                    <ul>
                        <li>Skolenhetskod: ${school.Skolenhetskod}</li>
                        <li>Skolenhetsnamn: ${school.Skolenhetsnamn}</li>
                        <li>Kommunkod: ${school.Kommunkod}</li>
                        <li>PeOrgNr: ${school.PeOrgNr}</li>
                    </ul>
                    `;
                });
                document.getElementById('output').innerHTML = output;
            })
    }

})();