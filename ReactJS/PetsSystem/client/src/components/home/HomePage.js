import React from 'react'
import petStore from '../../stores/PetStore'
import PetsList from '../pets/PetsList'

export default class Name extends React.Component {
  constructor (props) {
    super(props)

    this.state = {
      pets: [],
      page: 1
    }

    this.handlePetsLoad = this.handlePetsLoad.bind(this)
    petStore.on(
      petStore.events.PETS_LOADED,
      this.handlePetsLoad)
  }

  componentWillUnmount () {
    petStore.removeListener(
      petStore.events.PETS_LOADED,
      this.handlePetsLoad)
  }

  handlePetsLoad (pets) {
    this.setState({pets})
  }

  componentDidMount () {
    this.loadPets(this.state.page)
  }

  loadPets (page) {
    petStore.getAll(page)
  }

  render () {
    return (
      <div className='container'>
        <h2>Welcome to Pets Social Network</h2>
        <PetsList pets={this.state.pets} />
      </div>
    )
  }
}
