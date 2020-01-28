(function () {
    'use strict';

    document.getElementById('getSchool').addEventListener("click", getData);

    function getData() {
        fetch('data/1290.json')
            .then((res) => res.json())
            .then((data) => {
                let output = '<h2>Schools</h2>';
                data.forEach(function (school) {
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