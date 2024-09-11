async function popuniOdeljenja() {
    const data = await fetch("https://localhost:44358/Odeljenje/PruzmiSvaOdeljenja");
    const odeljenja = await data.json();

    const tbody = document.querySelector("table>tbody");

    let i = 1;

    for (let o of odeljenja) {
        const row = document.createElement("tr");
        tbody.appendChild(row);

        const cellId = document.createElement("td");
        cellId.innerText = i++;
        row.appendChild(cellId);

        const cell1 = document.createElement("td");
        cell1.innerText = o.sifra;
        row.appendChild(cell1);

        const cell2 = document.createElement("td");
        cell2.innerText = o.tip;
        row.appendChild(cell2);


        const cellIP = document.createElement("td");
        cellIP.innerText = o.datum_izgradnje;
        row.appendChild(cellIP);

        
    }
}

async function kreirajProdavnice() {
    const data = await fetch("https://localhost:7234/Prodavnica/PreuzmiProdavnice");
    const prodavnice = await data.json();

    for (let p of prodavnice) {
        const prodavnica = document.querySelector("#prodavnica");
        const option = document.createElement("option");
        option.innerText = p.naziv + ` (${p.adresa})`;
        option.value = p.id;
        prodavnica.appendChild(option);
    }
}

async function kreirajOdeljenja() {
    const data = await fetch("https://localhost:44358/Odeljenje/PruzmiSvaOdeljenja");
    const odeljenja = await data.json();

    for (let o of odeljenja) {
        const lekar = document.querySelector("#lekar");
        const option = document.createElement("option");
        option.innerText = o.tipOdeljenja + ` (${o.sifra})`;
        option.value = o.sifra;
        lekar.appendChild(option);
    }
}

async function dodajOdeljenje() {
    const lekarID = document.querySelector("#lekar").value;

    let podaci = {
        tipOdeljenja: document.querySelector("#tipOdeljenja").value,
        datumIzgradnje: parseInt(document.querySelector("#datumIzgradnje").value)
    };

    const data = await fetch(`https://localhost:44358/Odeljenje/KreirajOdeljenje/${lekarID}`, {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(podaci)
    });

    if (data.ok) {
        alert("Uspeo upis odeljenja.");
    }
}

async function azurirajOdeljenje() {
    let podaci = {
        sifra: parseInt(document.querySelector("#odeljenje").value),
        tipOdeljenja: document.querySelector("#tipOdeljenja").value,
        datumIzgradnje: parseInt(document.querySelector("#datumIzgradnje").value)
    };

    const data = await fetch(`https://localhost:44358/Odeljenje/IzmenaOdeljenja`, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(podaci)
    });

    if (data.ok) {
        alert("Uspela izmena odeljenja.");
    }
}

async function obrisiOdeljenje() {
    let idOdeljenja = parseInt(document.querySelector("#odeljenje").value);

    const data = await fetch(`https://localhost:44358/Odeljenje/IzbrisiOdeljenje/${idOdeljenja}`, {
        method: "DELETE"
    });

    if (data.ok) {
        alert("Uspelo brisanje odeljenja.");
    }
}