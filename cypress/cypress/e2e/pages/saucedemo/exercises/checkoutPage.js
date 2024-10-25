class CheckoutPage {

    checkoutOrder(firstName, lastName, postalCode) {
        cy.get('input#first-name').type(firstName)
        cy.get('input#last-name').type(lastName)
        cy.get('input#postal-code').type(postalCode)
        cy.get('input#continue').click()
        cy.get('button#finish').click()
    }
}

export default CheckoutPage