class OrderConfirmationPage {

    orderConfirmation() {
        /**
         * TODO: Create a new class OrderConfirmationPage and add a method that returns
         *   the order confirmation message. Use that method instead of the direct call
         */
        cy.get('h2.complete-header')
        .should('be.visible')
        .should('have.text', 'Thank you for your order!')
    }
}

export default OrderConfirmationPage