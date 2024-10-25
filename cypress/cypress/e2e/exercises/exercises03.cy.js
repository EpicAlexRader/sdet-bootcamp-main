import HomePage from "../pages/saucedemo/answers/homePage";
import ProductsOverviewPage from "../pages/saucedemo/answers/productsOverviewPage";

//describe('Exercises 03 - before', () => {

    /**
     * TODO: refactor the following three tests into a single, parameterized test
     */

    // it('should successfully log in the standard_user', () => {

    //     new HomePage()
    //         .visit()
    //         .loginAs('standard_user', 'secret_sauce')

    //     new ProductsOverviewPage().getLinkToBackpack().should('be.visible')
    // })

    // it('should successfully log in the problem_user', () => {

    //     new HomePage()
    //         .visit()
    //         .loginAs('problem_user', 'secret_sauce')

    //     new ProductsOverviewPage().getLinkToBackpack().should('be.visible')
    // })

    // it('should successfully log in the visual_user', () => {

    //     new HomePage()
    //         .visit()
    //         .loginAs('visual_user', 'secret_sauce')

    //     new ProductsOverviewPage().getLinkToBackpack().should('be.visible')
    // })

    /**
     * TODO: (EXTRA) usually, the password also varies from one user to the next.
     *   Can you figure out how to also parameterize that? Feel free to use Google,
     *   StackOverflow, ChatGPT or any other acceptable source to find an answer.
     */

//})
describe ('Exercises 03 - after', () =>
{
    [
        'standard_user',
        'problem_user',
        'visual_user',
    ].forEach((username) => 
    {
        it(`should successfully log in with username ${username}`, () => 
        {
            
            new HomePage()
            .visit()
            .loginAs(username, 'secret_sauce')

            new ProductsOverviewPage().getLinkToBackpack().should('be.visible')
        })
    })
})

describe ('Exercises 03 - after with obj', () =>
{
    [
        {
            username: 'standard_user',
            password: 'secret_sauce'
        },
        {
            username: 'problem_user',
            password: 'secret_sauce'
        },
        {
            username: 'visual_user',
            password: 'secret_sauce'
        }
    ].forEach((credentials) => 
    {
        it(`should successfully log in with username ${credentials.username} and password ${credentials.password}`, () => 
        {
            
            new HomePage()
            .visit()
            .loginAs(credentials.username, credentials.password)

            new ProductsOverviewPage().getLinkToBackpack().should('be.visible')
        })
    })
})