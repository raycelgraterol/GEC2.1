
// funcion para updatear en firebase
function firebaseUpdate(colection, id, amountT, contact, profitC, profitE, profitGEC, amountE, profitN, myDate) {

    db.collection(colection).doc(id).set({

        montoTotalDB: amountT,
        contactoCheckBD: contact,
        gananciaCBD: profitC,
        gananciaEDB: profitE,
        gananciaGECDB: profitGEC,
        montoEntregaDB: amountE,
        gananciaNetaDB: profitN,
        fecha: myDate

    })
        .then(function () {
            console.log("Document successfully written!");
            var msnDiv = document.getElementById("mensajeError");
            msnDiv.innerHTML = `<div class="alert alert-success">Se a Actualizado con EXITO la remesa.</div>`;
        })
        .catch(function (error) {
            console.error("Error writing document: ", error);
        });
}


// funcion para poner los datos en la tabla desde firebase

function getTable(querySnapshot, remittancesTable, i) {

    var existDoc = null;

    querySnapshot.forEach(function (doc) {
        // doc.data() is never undefined for query doc snapshots
        console.log(doc.id, " => ", doc.data());
        existDoc = doc.id;

        remittancesTable.innerHTML += `
                        <tr>
                          <th>${doc.data().fecha}</th>
                          <td>${doc.data().pais}</td>
                          <td>${doc.data().gananciaGECDB}</td>
                          <td>${doc.data().gananciaEDB}</td>
                          <td>${doc.data().gananciaCBD}</td>
                          <td>${doc.data().montoEntregaDB}</td>
                          <td>${doc.data().gananciaNetaDB}</td>
                          <td>${doc.data().montoTotalDB}</td>
                          <td>
                              <button type="button" class="btn btn-success" id="actualizarRemesa" name="actualizarRemesa" onclick="saveDataId('${doc.id}', ${i})">
                                <i class="cui-pencil icons font-2xl d-block mt-4"></i>
                              </button>
                          </td>
                        </tr>
                
                    `;

        dataremittances1[i] = doc.data().contactoCheckBD;
        dataremittances2[i] = doc.data().gananciaCBD;
        dataremittances3[i] = doc.data().gananciaEDB;
        dataremittances4[i] = doc.data().gananciaGECDB;
        dataremittances5[i] = doc.data().montoEntregaDB;
        dataremittances6[i] = doc.data().gananciaNetaDB;
        dataremittances7[i] = doc.data().montoTotalDB;
        i++;

    });

    return existDoc;
}

function addFirebase(db, colection, amountT, contact, profitC, profitE, profitGEC, amountE, profitN, myDate, myContry) {

    db.collection(colection).add({

        montoTotalDB: amountT,
        contactoCheckBD: contact,
        gananciaCBD: profitC,
        gananciaEDB: profitE,
        gananciaGECDB: profitGEC,
        montoEntregaDB: amountE,
        gananciaNetaDB: profitN,
        fecha: myDate,
        pais: myContry

    }).then(function (docRef) {
        console.log("Document written with ID: ", docRef.id);
        var msnDiv = document.getElementById("mensajeError");
        msnDiv.innerHTML = `<div class="alert alert-success">Se a Guardado con EXITO la remesa.</div>`
    })
        .catch(function (error) {
            console.error("Error adding document: ", error);
        });
}