using System;

public class SpaceAge
{
    private const int ONE_YEAR_ON_EARTH_IN_SEC = 31557600;

    private const double MERCURY_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO = 0.2408467;
    private const double VENUS_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO = 0.61519726;
    private const double MARS_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO = 1.8808158;
    private const double JUPITER_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO = 11.862615;
    private const double SATURN_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO = 29.447498;
    private const double URANUS_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO = 84.016846;
    private const double NEPTUN_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO = 164.79132;

    private double yearsOnEarth = 0;
    public SpaceAge(int seconds)
    {
        yearsOnEarth = OnEarth(seconds);
    }

    private double OnEarth(int seconds) => (double)seconds / ONE_YEAR_ON_EARTH_IN_SEC;
    public double OnEarth()
    {
        return yearsOnEarth;
    }
    public double OnMercury()
    {
        return Math.Pow(MERCURY_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO, -1) * yearsOnEarth;
    }

    public double OnVenus()
    {
        return Math.Pow(VENUS_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO, -1) * yearsOnEarth;
    }

    public double OnMars()
    {
        return Math.Pow(MARS_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO, -1) * yearsOnEarth;
    }

    public double OnJupiter()
    {
        return Math.Pow(JUPITER_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO, -1) * yearsOnEarth;
    }

    public double OnSaturn()
    {
        return Math.Pow(SATURN_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO, -1) * yearsOnEarth;
    }

    public double OnUranus()
    {
        return Math.Pow(URANUS_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO, -1) * yearsOnEarth;
    }

    public double OnNeptune()
    {
        return Math.Pow(NEPTUN_ORBITRAL_PERIOD_TO_EARTH_YEARS_RATIO, -1) * yearsOnEarth;
    }
}